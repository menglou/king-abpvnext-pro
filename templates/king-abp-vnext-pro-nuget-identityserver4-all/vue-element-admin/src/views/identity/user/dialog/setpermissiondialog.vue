<template>
  <!--权限弹窗-->
  <vxe-modal
    v-model="permissiondialogFormVisible"
    :title="permissiontitle"
    :position="{ top: 40 }"
    width="600"
    :lock-scroll="false"
    class="permsimodal"
    @close="permissionmodalclose"
  >
    <template v-slot>
      <div class="tabs-permmison">
        <el-checkbox
          :value="grantperm.length == allpermission.length"
          @change="handleCheckAllChange"
          >授予所有权限</el-checkbox
        >
        <el-divider />
        <el-tabs style="height: auto" tab-position="left">
          <el-tab-pane
            v-for="item in permissiongroup"
            :key="item.displayName"
            class="tab-pane"
            :label="
              item.displayName +
              '(' +
              grantperm
                .filter((x) => x.key == item.displayName)
                .map((res) => {
                  return res.name;
                }).length +
              ')'
            "
          >
            <div style="padding-left: 10px">
              <span style="font-size: 17px; font-weight: 800">{{
                item.displayName
              }}</span>
              <el-divider />
              <el-checkbox
                :value="
                  (item.permissions.filter((x) => x.isGranted == true).length ==
                    item.permissions.length) ==
                  true
                    ? true
                    : false
                "
                @change="tabhandleCheckAllChange(item.permissions, $event)"
                >全选</el-checkbox
              >
              <el-divider />
              <div class="permissionscroller">
                <el-scrollbar style="height: 100%">
                  <el-tree
                    ref="permtree"
                    check-strictly
                    show-checkbox
                    default-expand-all
                    node-key="name"
                    :data="transformPermissionTree(item.permissions)"
                    :props="defaultProps"
                    :default-checked-keys="
                      item.permissions
                        .filter((x) => x.isGranted == true)
                        .map((res) => {
                          return res.name;
                        })
                    "
                    @check="
                      (...defaultArgs) =>
                        treecheck(item.permissions, ...defaultArgs)
                    "
                  />
                </el-scrollbar>
              </div>
            </div>
          </el-tab-pane>
        </el-tabs>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="editpermission">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import {
  getPermissions,
  updatePermissions,
} from "@/api/permission-management/permission";
import { fetchAppConfig } from "@/utils/abp";
export default {
  name: "Setpermissiondialog",
  data() {
    return {
      callbackmethod: null,
      // 权限
      permissiondialogFormVisible: false,
      permissiontitle: "",
      permissiongroup: [],
      userid: "",
      defaultProps: {
        children: "child",
        label: "displayName",
      },
    };
  },
  computed: {
    grantperm() {
      const garntgroup = [];
      for (const i of this.permissiongroup) {
        for (const m of i.permissions) {
          if (m.isGranted == true) {
            const param = {
              key: i.displayName,
              name: m.name,
            };
            garntgroup.push(param);
          }
        }
      }
      return garntgroup;
    },
    allpermission() {
      const allpermissiongroup = [];
      for (const i of this.permissiongroup) {
        for (const m of i.permissions) {
          const param = {
            key: i.displayName,
            name: m.name,
          };
          allpermissiongroup.push(param);
        }
      }
      return allpermissiongroup;
    },
  },
  methods: {
    async createsetpermissiondialog(cb, userid) {
      this.callbackmethod = cb;
      this.userid = userid;
      await this.getpermissions(userid);
      this.permissiondialogFormVisible = true;
    },

    // 获取权限
    async getpermissions(userid) {
      const pamram = {
        providerName: "U",
        providerKey: userid,
      };
      const res = await getPermissions(pamram);
      this.permissiongroup = [...res.groups];
    },
    permissionmodalclose() {
      this.userid = "";
      this.callbackmethod = null;
      this.permissiongroup = [];
      this.permissiondialogFormVisible = false;
    },
    editpermission() {
      const tempData = [];
      const s = this.permissiongroup;
      for (const i of this.permissiongroup) {
        for (const m of i.permissions) {
          tempData.push({
            isGranted: m.isGranted,
            name: m.name,
          });
        }
      }
      const query = {
        providerName: "U",
        providerKey: this.userid,
      };
      updatePermissions(query, { permissions: tempData }).then((res) => {
        this.$notify({
          title: "提示",
          message: "权限修改成功",
          type: "success",
        });
        // 重置
        this.permissionmodalclose();
        fetchAppConfig(query.providerKey, query.providerName);
      });
    },
    //tab下全选
    tabhandleCheckAllChange(permissions, val) {
      debugger;
      if (val) {
        permissions.forEach((x) => {
          x.isGranted = true;
        });
      } else {
        permissions.forEach((x) => {
          if (this.isGrantedByOtherProviderName(x.grantedProviders) == false) {
            x.isGranted = false;
          }
        });
      }
    },
    // tree勾选事件
    treecheck(permissions, data, treenode) {
      const selectnode = [...treenode.checkedKeys, ...treenode.halfCheckedKeys];

      permissions.forEach((x) => {
        x.isGranted = false;
      });
      for (const i of selectnode) {
        permissions.find((x) => x.name == i).isGranted = true;
      }
    },
    // 构造权限树
    transformPermissionTree(permissions, name = null) {
      const arr = [];
      if (!permissions || !permissions.some((v) => v.parentName === name)) {
        return arr;
      }
      const tmpperm = permissions.filter((x) => x.parentName == name);
      for (const i of tmpperm) {
        arr.push({
          name: i.name,
          displayName:
            i.displayName +
            i.grantedProviders.map((provider) => {
              return "(" + `${provider.providerName}` + ")";
            }),
          disabled: this.isGrantedByOtherProviderName(i.grantedProviders),
          parentName: i.parentName,
          child: this.transformPermissionTree(permissions, i.name),
        });
      }
      return arr;
    },
    isGrantedByOtherProviderName(grantedProviders) {
      if (grantedProviders.length) {
        return grantedProviders.findIndex((p) => p.providerName !== "U") > -1;
      }
      return false;
    },
    // 授予所有权限
    handleCheckAllChange(val) {
      if (val) {
        for (const i of this.permissiongroup) {
          for (const m of i.permissions) {
            m.isGranted = true;
          }
        }
      } else {
        for (const i of this.permissiongroup) {
          for (const m of i.permissions) {
            if (
              this.isGrantedByOtherProviderName(m.grantedProviders) == false
            ) {
              m.isGranted = false;
            }
          }
        }
      }
    },
  },
};
</script>

<style scoped>
.modal-footer {
  border-top: 1px solid #eee;
  height: 50px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: flex-end;
  padding-right: 15px;
}
.permissionscroller {
  height: 400px;
}

/*权限树的样式*/
.tabs-permmison {
  padding-top: 10px;
  padding-bottom: 20px;
  padding-left: 10px;
  padding-right: 10px;
}
::v-deep .el-divider--horizontal {
  margin: 12px 0;
}
::v-deep .el-scrollbar__wrap {
  overflow-x: hidden;
}
</style>
