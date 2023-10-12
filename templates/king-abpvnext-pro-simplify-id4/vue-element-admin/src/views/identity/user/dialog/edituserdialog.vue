<template>
  <vxe-modal
    v-model="usereditdialogFormVisible"
    type="modal "
    :title="title"
    :position="{ top: 40 }"
    width="600"
    @close="editusermodalclose"
  >
    <template v-slot>
      <el-tabs v-model="activeName" class="tabs">
        <el-tab-pane label="用户信息" name="first">
          <el-form
            ref="usereditform"
            :model="usereditform"
            :rules="usereditrules"
            label-width="80px"
          >
            <el-form-item
              :label="$t('AbpIdentity[\'UserName\']')"
              prop="userName"
            >
              <el-input v-model="usereditform.userName" />
            </el-form-item>
            <el-form-item :label="$t('AbpIdentity[\'DisplayName:Name\']')">
              <el-input v-model="usereditform.surname" />
            </el-form-item>
            <el-form-item :label="$t('AbpIdentity[\'DisplayName:Surname\']')">
              <el-input v-model="usereditform.name" />
            </el-form-item>
            <el-form-item
              :label="$t('AbpIdentity[\'Password\']')"
              prop="password"
              :class="{ 'is-required': !usereditform.id }"
            >
              <el-input
                v-model="usereditform.password"
                type="password"
                auto-complete="off"
              />
            </el-form-item>
            <el-form-item
              :label="$t('AbpIdentity[\'EmailAddress\']')"
              prop="email"
            >
              <el-input v-model="usereditform.email" />
            </el-form-item>
            <el-form-item
              :label="$t('AbpIdentity[\'PhoneNumber\']')"
              prop="phoneNumber"
            >
              <el-input v-model="usereditform.phoneNumber" />
            </el-form-item>
            <el-form-item prop="lockoutEnabled">
              <el-checkbox
                v-model="usereditform.lockoutEnabled"
                :label="$t('AbpIdentity[\'DisplayName:LockoutEnabled\']')"
              />
            </el-form-item>
            <el-form-item prop="twoFactorEnabled">
              <el-checkbox
                v-model="usereditform.twoFactorEnabled"
                :label="$t('AbpIdentity[\'DisplayName:TwoFactorEnabled\']')"
              />
            </el-form-item>
          </el-form>
        </el-tab-pane>
        <el-tab-pane label="角色" name="second">
          <el-checkbox-group v-model="usereditform.roleNames">
            <el-checkbox
              v-for="item in rolelist"
              :key="item.id"
              :value="item.id"
              :label="item.name"
            />
          </el-checkbox-group>
        </el-tab-pane>
        <el-tab-pane label="组织机构" name="third">
          <el-input
            v-model="filterText"
            placeholder="输入关键字进行过滤"
            style="margin-bottom: 10px"
          />
          <div class="orgcardscroller">
            <el-scrollbar>
              <el-tree
                ref="edittree"
                :data="Treedata"
                node-key="id"
                :props="defaultProps"
                default-expand-all
                highlight-current
                :expand-on-click-node="false"
                :show-checkbox="true"
                :check-strictly="true"
                :filter-node-method="filterNode"
                :default-checked-keys="defaulykeys"
                @check-change="checkchange"
              />
            </el-scrollbar>
          </div>
        </el-tab-pane>
      </el-tabs>
      <div class="modal-footer">
        <el-button type="primary" @click="edituser">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import {
  getuserinfobyid,
  getorganizationbyid,
  getrolesbyid,
  updateuserToOrg,
} from "@/api/identity/user";
import { isEmpty, filterNode } from "@/utils";
import { getAllRoles } from "@/api/identity/roles";
import { GetOrganizationunitForTree } from "@/api/identity/organizationunit";
export default {
  name: "Edituserdialog",
  data() {
    const passwordValidator = (rule, value, callback) => {
      if (this.usereditform.id && !value) {
        callback();
        return;
      }

      if (!value) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['Password']"),
            ])
          )
        );
        return;
      }
      if (value.length < this.requiredLength) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['Volo.Abp.Identity:PasswordTooShort']", [
              `${this.requiredLength}`,
            ])
          )
        );
        return;
      }
      if (value.length > 128) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['Password']"), "128"]
            )
          )
        );
        return;
      }
      let reg = /\d+/;
      if (this.requireDigit && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['Volo.Abp.Identity:PasswordRequiresDigit']")
          )
        );
        return;
      }
      reg = /[a-z]+/;
      if (this.requireLowercase && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['Volo.Abp.Identity:PasswordRequiresLower']")
          )
        );
        return;
      }
      reg = /[A-Z]+/;
      if (this.requireUppercase && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['Volo.Abp.Identity:PasswordRequiresUpper']")
          )
        );
        return;
      }
      reg = /\W+/;
      if (this.requireNonAlphanumeric && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresNonAlphanumeric']"
            )
          )
        );
        return;
      }

      callback();
    };

    return {
      callbackmethod: null,
      title: "",
      usereditdialogFormVisible: false,
      usereditform: {
        id: "",
        userName: "",
        surname: "",
        name: "",
        email: "",
        phoneNumber: "",
        lockoutEnabled: true,
        twoFactorEnabled: true,
        roleNames: [],
        concurrencyStamp: "",
      },
      usereditrules: {
        userName: [
          {
            required: true,
            message: this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['UserName']"),
            ]),
            trigger: "blur",
          },
          {
            max: 256,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['UserName']"), "256"]
            ),
            trigger: "blur",
          },
        ],
        email: [
          {
            required: true,
            message: this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['EmailAddress']"),
            ]),
            trigger: "blur",
          },
          {
            type: "email",
            message: this.$i18n.t(
              "AbpIdentity['The {0} field is not a valid e-mail address.']",
              [this.$i18n.t("AbpIdentity['EmailAddress']")]
            ),
            trigger: ["blur", "change"],
          },
          {
            max: 256,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['EmailAddress']"), "256"]
            ),
            trigger: "blur",
          },
        ],
        name: [
          {
            max: 64,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['DisplayName:Name']"), "64"]
            ),
            trigger: "blur",
          },
        ],
        surname: [
          {
            max: 64,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['DisplayName:Surname']"), "64"]
            ),
            trigger: "blur",
          },
        ],
        phoneNumber: [
          {
            max: 16,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['PhoneNumber']"), "16"]
            ),
            trigger: "blur",
          },
        ],
        password: [
          { validator: passwordValidator, trigger: ["blur", "change"] },
        ],
      },
      activeName: "first",

      rolelist: [],
      Treedata: [], // 组织机构树
      defaulykeys: [],
      defaultProps: {
        children: "children",
        label: "displayName",
      },

      // tree过滤
      filterText: "",
      selecttreenodeChecked: [], // 被选中的节点
      updateremovetreenodechecked: [], // 更新时被移除的节点
    };
  },
  computed: {
    requiredLength() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          "Abp.Identity.Password.RequiredLength"
        ] || 6
      );
    },
    requiredUniqueChars() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          "Abp.Identity.Password.RequiredUniqueChars"
        ] || 1
      );
    },
    requireLowercase() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          "Abp.Identity.Password.RequireLowercase"
        ] || true
      );
    },
    requireNonAlphanumeric() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          "Abp.Identity.Password.RequireNonAlphanumeric"
        ] || true
      );
    },
    requireUppercase() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          "Abp.Identity.Password.RequireUppercase"
        ] || true
      );
    },
    requireDigit() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          "Abp.Identity.Password.RequireDigit"
        ] || true
      );
    },
  },
  methods: {
    filterNode,
    isEmpty,
    async createedituserdialog(cb, title, userid) {
      this.callbackmethod = cb;
      this.title = title;
      this.usereditform.id = userid;
      this.usereditdialogFormVisible = true;
      await this.getrolelist();
      await this.getorganizationunit();

      // 填充用户信息
      await this.getuserinfobyid(userid);

      // //填充角色信息
      await this.getorganizationbyid(userid);

      // //填充组织信息
      await this.getrolesbyid(userid);
    },
    editusermodalclose() {
      this.$refs.usereditform.resetFields();
      this.activeName = "first";
      this.usereditform.roleNames = [];
      this.selecttreenodeChecked = [];
      this.title = "";
      this.callbackmethod = null;
      this.usereditform.surname = "";
      this.usereditform.name = "";
      this.defaulykeys = [];
      this.usereditdialogFormVisible = false;
    },
    edituser() {
      const param = this.usereditform;
      if (this.isEmpty(this.usereditform.surname) == true) {
        this.usereditform.surname = this.usereditform.userName;
      }
      if (this.isEmpty(this.usereditform.name) == true) {
        this.usereditform.name = this.usereditform.userName;
      }
      param.orgIds = this.selecttreenodeChecked.map((item) => {
        return item.id;
      });
      updateuserToOrg(this.usereditform.id, param).then((res) => {
        this.$notify({
          title: "提示",
          message: "修改用户成功",
          type: "success",
        });
        this.callbackmethod();
        this.editusermodalclose();
      });
    },
    async getrolelist() {
      const res = await getAllRoles();
      this.rolelist = [...res.items];
    },
    // 获取组织树
    async getorganizationunit() {
      const res = await GetOrganizationunitForTree();
      this.Treedata = [];
      this.Treedata = [...res.items];
    },

    // 根据用户id获取用户信息
    async getuserinfobyid(userid) {
      const res = await getuserinfobyid(userid);
      this.usereditform.id = res.id;
      this.usereditform.userName = res.userName;
      this.usereditform.surname = res.surname;
      this.usereditform.name = res.name;
      this.usereditform.email = res.email;
      this.usereditform.phoneNumber = res.phoneNumber;
      this.usereditform.lockoutEnabled = res.lockoutEnabled;
      this.usereditform.concurrencyStamp = res.concurrencyStamp;
    },

    // 根据用户id获取组织信息
    async getorganizationbyid(userid) {
      const res = await getorganizationbyid(userid);
      const organizationinfo = res.items;
      const ids = organizationinfo.map((org) => {
        return org.id;
      });
      this.defaulykeys = ids;
      this.selecttreenodeChecked = [];
      this.selecttreenodeChecked.push(...res.items);
      console.log("选择的节点");
      console.log(this.selecttreenodeChecked);
    },
    // 根据用户id获取角色信息
    async getrolesbyid(userid) {
      const res = await getrolesbyid(userid);
      const ids = res.items.map((role) => {
        return role.name;
      });
      this.usereditform.roleNames = ids;
    },

    // tree勾选事件
    checkchange(nodedata, checked) {
      if (checked) {
        if (
          this.selecttreenodeChecked.findIndex((x) => x.id == nodedata.id) == -1
        ) {
          this.selecttreenodeChecked.push(nodedata);
        }
      } else {
        const treeobjindex = this.selecttreenodeChecked.findIndex(
          (x) => x.id == nodedata.id
        );
        if (treeobjindex != -1) {
          this.selecttreenodeChecked.splice(treeobjindex, 1);
        }

        const treeobjindexs = this.updateremovetreenodechecked.findIndex(
          (x) => x.id == nodedata.id
        );
        if (treeobjindexs == -1) {
          this.updateremovetreenodechecked.push(nodedata);
        }
      }
    },
  },
};
</script>

<style scoped>
.orgcardscroller {
  height: 500px;
}
.modal-footer {
  border-top: 1px solid #eee;
  height: 50px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: flex-end;
  padding-right: 15px;
}
.tabs {
  margin: 0.8em 1em;
}

::v-deep .el-tabs__nav-wrap::after {
  height: 1.5px;
}
::v-deep .vxe-modal--footer {
  border-top: 1px solid #eee;
}
::v-deep .vxe-modal--wrapper .vxe-modal--footer {
  padding: 5px 10px;
}
</style>
