<template>
  <vxe-modal
    v-model="useradddialogFormVisible"
    type="modal "
    title="添加用户"
    :position="{ top: 40 }"
    width="600"
    @close="addusermodalclose"
  >
    <template v-slot>
      <el-tabs v-model="activeName" class="tabs">
        <el-tab-pane label="用户信息" name="first">
          <el-form
            ref="adduserForm"
            :model="adduserForm"
            :rules="adduserFormrules"
            label-width="80px"
          >
            <el-form-item
              :label="$t('AbpIdentity[\'UserName\']')"
              prop="userName"
            >
              <el-input v-model="adduserForm.userName" />
            </el-form-item>
            <el-form-item :label="$t('AbpIdentity[\'DisplayName:Name\']')">
              <el-input v-model="adduserForm.surname" />
            </el-form-item>
            <el-form-item :label="$t('AbpIdentity[\'DisplayName:Surname\']')">
              <el-input v-model="adduserForm.name" />
            </el-form-item>
            <el-form-item
              :label="$t('AbpIdentity[\'Password\']')"
              prop="password"
            >
              <el-input
                v-model="adduserForm.password"
                type="password"
                auto-complete="off"
              />
            </el-form-item>
            <el-form-item
              :label="$t('AbpIdentity[\'EmailAddress\']')"
              prop="email"
            >
              <el-input v-model="adduserForm.email" />
              <span>确保邮箱是正确的，忘记密码时可以通过邮箱接收修改密码的邮件修改</span>
            </el-form-item>
            <el-form-item :label="$t('AbpIdentity[\'PhoneNumber\']')">
              <el-input v-model="adduserForm.phoneNumber" />
            </el-form-item>
            <el-form-item>
              <el-checkbox
                v-model="adduserForm.lockoutEnabled"
                :label="$t('AbpIdentity[\'DisplayName:LockoutEnabled\']')"
              />
            </el-form-item>
            <el-form-item prop="twoFactorEnabled">
              <el-checkbox
                v-model="adduserForm.twoFactorEnabled"
                :label="$t('AbpIdentity[\'DisplayName:TwoFactorEnabled\']')"
              />
            </el-form-item>
          </el-form>
        </el-tab-pane>
        <el-tab-pane :label="$t('AbpIdentity[\'Roles\']')" name="second">
          <el-checkbox-group v-model="adduserForm.roleNames">
            <el-checkbox
              v-for="item in rolelist"
              :key="item.id"
              :value="item.id"
              :label="item.name"
            />
          </el-checkbox-group>
        </el-tab-pane>
        <el-tab-pane
          :label="$t('AbpIdentity[\'OrganitaionUnits\']')"
          name="third"
        >
          <el-input
            v-model="filterText"
            placeholder="输入关键字进行过滤"
            style="margin-bottom: 10px"
          />
          <div class="orgcardscroller">
            <el-scrollbar>
              <el-tree
                ref="tree"
                :data="Treedata"
                node-key="id"
                :props="defaultProps"
                default-expand-all
                highlight-current
                :expand-on-click-node="false"
                :show-checkbox="true"
                :check-strictly="true"
                :filter-node-method="filterNode"
                @check-change="checkchange"
              />
            </el-scrollbar>
          </div>
        </el-tab-pane>
      </el-tabs>
      <div class="modal-footer">
        <el-button type="primary" @click="saveuser">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { addusertoorganization } from '@/api/identity/user'
import { getAllRoles } from '@/api/identity/roles'
import { GetOrganizationunitForTree } from '@/api/identity/organizationunit'
import { isEmpty, filterNode } from '@/utils'
export default {
  name: 'Adduserdialog',
  data() {
    const passwordValidator = (rule, value, callback) => {
      if (this.adduserForm.id && !value) {
        callback()
        return
      }

      if (!value) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['Password']")
            ])
          )
        )
        return
      }
      if (value.length < this.requiredLength) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['Volo.Abp.Identity:PasswordTooShort']", [
              `${this.requiredLength}`
            ])
          )
        )
        return
      }
      if (value.length > 128) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['Password']"), '128']
            )
          )
        )
        return
      }
      let reg = /\d+/
      if (this.requireDigit && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresDigit']"
            )
          )
        )
        return
      }
      reg = /[a-z]+/
      if (this.requireLowercase && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresLower']"
            )
          )
        )
        return
      }
      reg = /[A-Z]+/
      if (this.requireUppercase && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresUpper']"
            )
          )
        )
        return
      }
      reg = /\W+/
      if (this.requireNonAlphanumeric && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresNonAlphanumeric']"
            )
          )
        )
        return
      }

      callback()
    }
    return {
      callbackmethod: null,
      // 添加用户弹窗
      useradddialogFormVisible: false,
      adduserForm: {
        userName: '',
        surname: '',
        name: '',
        password: '',
        email: '',
        isActive: true,
        phoneNumber: '',
        lockoutEnabled: true,
        twoFactorEnabled: true,
        roleNames: [],
        isActive: true
      },
      adduserFormrules: {
        userName: [
          {
            required: true,
            message: this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['UserName']")
            ]),
            trigger: 'blur'
          },
          {
            max: 256,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['UserName']"), '256']
            ),
            trigger: 'blur'
          }
        ],
        email: [
          {
            required: true,
            message: this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['EmailAddress']")
            ]),
            trigger: 'blur'
          },
          {
            type: 'email',
            message: this.$i18n.t(
              "AbpIdentity['The {0} field is not a valid e-mail address.']",
              [this.$i18n.t("AbpIdentity['EmailAddress']")]
            ),
            trigger: ['blur', 'change']
          },
          {
            max: 256,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['EmailAddress']"), '256']
            ),
            trigger: 'blur'
          }
        ],
        name: [
          {
            max: 64,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['DisplayName:Name']"), '64']
            ),
            trigger: 'blur'
          }
        ],
        surname: [
          {
            max: 64,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['DisplayName:Surname']"), '64']
            ),
            trigger: 'blur'
          }
        ],
        phoneNumber: [
          {
            max: 16,
            message: this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['PhoneNumber']"), '16']
            ),
            trigger: 'blur'
          }
        ],
        password: [
          { validator: passwordValidator, trigger: ['blur', 'change'] }
        ]
      },
      activeName: 'first',
      Treedata: [], // 组织机构树
      defaulykeys: [],
      defaultProps: {
        children: 'children',
        label: 'displayName'
      },

      // tree过滤
      filterText: '',
      selecttreenodeChecked: [], // 被选中的节点
      updateremovetreenodechecked: [], // 更新时被移除的节点

      rolelist: []
    }
  },
  computed: {
    requiredLength() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequiredLength'
        ] || 6
      )
    },
    requiredUniqueChars() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequiredUniqueChars'
        ] || 1
      )
    },
    requireLowercase() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireLowercase'
        ] || true
      )
    },
    requireNonAlphanumeric() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireNonAlphanumeric'
        ] || true
      )
    },
    requireUppercase() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireUppercase'
        ] || true
      )
    },
    requireDigit() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireDigit'
        ] || true
      )
    }
  },
  methods: {
    filterNode,
    isEmpty,
    async createadduserdialog(cb) {
      this.callbackmethod = cb
      this.useradddialogFormVisible = true
      await this.getrolelist()
      await this.getorganizationunit()
    },
    addusermodalclose() {
      this.$refs.adduserForm.resetFields()
      this.activeName = 'first'
      this.adduserForm.roleNames = []
      this.adduserForm.surname = ''
      this.adduserForm.name = ''
      this.adduserForm.isActive = true
      this.callbackmethod = null
      this.selecttreenodeChecked = []
      this.useradddialogFormVisible = false
    },

    saveuser() {
      this.$refs.adduserForm.validate((valid) => {
        if (valid) {
          // 调用添加用户接口
          const param = this.adduserForm
          if (this.isEmpty(this.adduserForm.surname) == true) {
            this.adduserForm.surname = this.adduserForm.userName
          }
          if (this.isEmpty(this.adduserForm.name) == true) {
            this.adduserForm.name = this.adduserForm.userName
          }
          param.orgIds = this.selecttreenodeChecked.map((item) => {
            return item.id
          })
          addusertoorganization(param).then((res) => {
            if (res) {
              this.$notify({
                title: '提示',
                message: '添加用户成功',
                type: 'success'
              })
              this.callbackmethod()
              this.addusermodalclose()
            }
          })
          // 添加组织信息接口
        } else {
          this.useradddialogFormVisible = true
          return false
        }
      })
    },
    // tree勾选事件
    checkchange(nodedata, checked) {
      if (checked) {
        if (
          this.selecttreenodeChecked.findIndex((x) => x.id == nodedata.id) == -1
        ) {
          this.selecttreenodeChecked.push(nodedata)
        }
      } else {
        const treeobjindex = this.selecttreenodeChecked.findIndex(
          (x) => x.id == nodedata.id
        )
        if (treeobjindex != -1) {
          this.selecttreenodeChecked.splice(treeobjindex, 1)
        }

        const treeobjindexs = this.updateremovetreenodechecked.findIndex(
          (x) => x.id == nodedata.id
        )
        if (treeobjindexs == -1) {
          this.updateremovetreenodechecked.push(nodedata)
        }
      }
    },
    async getrolelist() {
      const res = await getAllRoles()
      this.rolelist = [...res.items]
    },
    // 获取组织树
    async getorganizationunit() {
      const res = await GetOrganizationunitForTree()
      this.Treedata = [...res.items]
    }
  }
}
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
