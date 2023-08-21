<template>
  <div class="app-container">
    <el-row :gutter="24">
      <el-col :md="10">
        <el-card class="box-card">
          <div slot="header" class="clearfix">
            <span><i class="el-icon-share"> 组织结构树</i> </span>
            <span class="rightmenu">
              <el-button
                v-if="checkPermission('AbpIdentity.OrganitaionUnits.Create')"
                class="btnaddroot"
                type="text"
                @click="addrootorg"
              >
                <i class="el-icon-plus">添加根组织</i>
              </el-button>
              <span style="font-size: 10px; padding: 4px 10px; color: #eee"
                >|</span
              >
              <el-tooltip
                class="item"
                effect="dark"
                content="刷新"
                placement="top"
              >
                <i
                  class="el-icon-refresh-right refresh-icon"
                  @click="getorganizationunit"
                />
              </el-tooltip>
            </span>
          </div>
          <el-scrollbar ref="scrollbar" class="orgcardscroller">
            <el-tree
              ref="tree"
              :data="Treedata"
              node-key="id"
              :props="defaultProps"
              default-expand-all
              highlight-current
              :expand-on-click-node="false"
              @node-contextmenu="contextmenuhandler"
              @node-click="nodeclick"
            >
              <span slot-scope="{ node }" class="custom-tree-node">
                <i
                  :class="
                    node.expanded ? 'el-icon-folder-opened' : 'el-icon-folder'
                  "
                />
                <span class="node-icon-label">{{ node.label }}</span>
                <span style="font-size: 10px; margin-left: 3px; color: #a0a0a0"
                  >{{ node.data.userInOrgCount }}组织成员,角色</span
                >
              </span>
            </el-tree>
          </el-scrollbar>
        </el-card>
      </el-col>
      <el-col :md="14">
        <el-card>
          <div slot="header" class="clearfix">
            <span>{{ userinorgtitle }}</span>
          </div>

          <template
            v-if="Object.keys(this.currentchecknode).length == 0 ? false : true"
          >
            <template>
              <div class="header-toolbar">
                <el-button
                  v-if="
                    checkPermission(
                      'AbpIdentity.Users.DistributionOrganizationUnit'
                    )
                  "
                  size="small"
                  icon="el-icon-plus"
                  type="primary"
                  @click="adduserinorg"
                  >添加成员</el-button
                >
              </div>
            </template>
            <el-scrollbar class="userinorgcardscroller">
              <vxe-table
                id="orginuser"
                :data="orguserDataLit"
                auto-resize
                align="center"
                :custom-config="{ storage: true }"
                border="inner"
              >
                <vxe-table-column type="seq" width="60" />
                <vxe-table-column v-if="false" field="id" width="60" />
                <vxe-table-column title="用户名" field="userName" />
                <vxe-table-column title="创建时间" field="creationTime">
                  <template v-slot="{ row }">
                    {{ moment(row.creationTime).format("YYYY-MM-DD") }}
                  </template>
                </vxe-table-column>
                <vxe-table-column title="操作">
                  <template v-slot="{ row }">
                    <vxe-button
                      v-if="
                        checkPermission(
                          'AbpIdentity.Users.DistributionOrganizationUnit'
                        )
                      "
                      type="text"
                      status="danger"
                      content="删除"
                      @click="deleteuserinorg(row.id)"
                    />
                  </template>
                </vxe-table-column>
              </vxe-table>
              <vxe-pager
                background
                :current-page.sync="tablePage.currentPage"
                :page-size.sync="tablePage.pageSize"
                :total="tablePage.totalResult"
                :layouts="[
                  'PrevJump',
                  'PrevPage',
                  'JumpNumber',
                  'NextPage',
                  'NextJump',
                  'Sizes',
                  'FullJump',
                  'Total',
                ]"
                @page-change="handlePageChange"
              />
            </el-scrollbar>
          </template>

          <template v-else>
            <el-empty description="选择一个组织成员" />
            <el-empty description="选择一个组织成员" />
          </template>
        </el-card>
      </el-col>
    </el-row>
    <el-dialog title="新建组织机构" :visible.sync="dialogaddrootorgFormVisible">
      <el-form
        ref="addrootorgForm"
        :model="addrootorfForm"
        :rules="addrootorgFormrules"
      >
        <el-form-item
          v-if="addrootorfForm.parentId === null ? false : true"
          label="所属父组织"
          label-width="100px"
        >
          <el-input
            v-model="addrootorfForm.parentName"
            disabled
            autocomplete="off"
          />
        </el-form-item>
        <el-form-item
          label="组织名称"
          :label-width="addrootorfForm.parentId === 0 ? '80px' : '100px'"
          prop="displayName"
        >
          <el-input v-model="addrootorfForm.displayName" autocomplete="off" />
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="canceladdrootorgForm">取 消</el-button>
        <el-button type="primary" @click="confirmaddrootorgForm"
          >确 定</el-button
        >
      </div>
    </el-dialog>
    <el-dialog title="修改组织机构" :visible.sync="dialogeditorgFormVisible">
      <el-form
        ref="editrootorgForm"
        :model="editrootorgForm"
        :rules="editrootorgFormrules"
      >
        <el-form-item
          v-if="editrootorgForm.parentId === null ? false : true"
          label="当前所属父组织"
          label-width="130px"
        >
          <el-select
            v-model="editrootorgForm.parentId"
            style="width: 100%"
            disabled
          >
            <el-option
              v-for="item in allorgdatapinjie"
              :key="item.id"
              :value="item.id"
              :label="item.parentName + '-' + item.displayName"
            />
          </el-select>
          <!-- <el-input
            disabled
            v-model="editrootorgForm.parentName"
            autocomplete="off"
          ></el-input> -->
        </el-form-item>
        <el-form-item label="更改所属父组织" label-width="130px">
          <el-select
            v-model="editrootorgForm.updateparentId"
            style="width: 100%"
            filterable
            clearable
          >
            <el-option
              v-for="item in allorgdatapinjie"
              :key="item.id"
              :value="item.id"
              :label="item.parentName + '-' + item.displayName"
            />
          </el-select>
        </el-form-item>
        <el-form-item label="组织名称" label-width="130px" prop="displayName">
          <el-input v-model="editrootorgForm.displayName" autocomplete="off" />
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="canceleditorgForm">取 消</el-button>
        <el-button type="primary" @click="confirmeditorgForm">确 定</el-button>
      </div>
    </el-dialog>
    <div v-if="showMenu" :style="classname" class="menu">
      <ul>
        <li
          v-if="checkPermission('AbpIdentity.OrganitaionUnits.Update')"
          @click="updatetreenode"
        >
          <i class="el-icon-edit" /> 修改
        </li>
        <li
          v-if="checkPermission('AbpIdentity.OrganitaionUnits.Create')"
          @click="addchildorg"
        >
          <i class="el-icon-document-add" /> 添加子组织
        </li>
        <li
          v-if="checkPermission('AbpIdentity.OrganitaionUnits.Delete')"
          @click="deleteorg"
        >
          <i class="el-icon-delete" /> 删除
        </li>
      </ul>
    </div>
    <el-dialog
      title="添加组织成员"
      :visible.sync="dialogaddorgUserFormVisible"
      top="8vh"
      @close="addorgUserdialogclose"
    >
      <template>
        <div class="header-toolbar">
          <el-button
            size="small"
            icon="el-icon-plus"
            type="primary"
            @click="saveusertoorg"
            >保存</el-button
          >
        </div>
      </template>
      <vxe-table
        id="orginuser"
        :data="userDataLit"
        class="userinorgdialog"
        auto-resize
        max-height="450"
        align="center"
        :custom-config="{ storage: true }"
        border="inner"
        :checkbox-config="{ checkMethod: checCheckboxkMethod }"
        @checkbox-change="checkboxchange"
        @checkbox-all="checkall"
      >
        >
        <vxe-column type="checkbox" width="60" />
        <vxe-table-column type="seq" width="60" />
        <vxe-table-column v-if="false" field="id" width="60" />
        <vxe-table-column width="140" title="是否已经是该组织成员">
          <template v-slot="{ row }">
            <template
              v-if="orguserDataLit.findIndex((x) => x.id == row.id) != -1"
            >
              <el-tag type="success" effect="dark"> 是 </el-tag>
            </template>
            <template v-else>
              <el-tag type="info" effect="dark"> 否 </el-tag>
            </template>
          </template>
        </vxe-table-column>
        <vxe-table-column title="用户名" field="userName" />
      </vxe-table>
      <vxe-pager
        background
        :current-page.sync="tableforUserListPage.currentPage"
        :page-size.sync="tableforUserListPage.pageSize"
        :total="tableforUserListPage.totalResult"
        :layouts="[
          'PrevJump',
          'PrevPage',
          'JumpNumber',
          'NextPage',
          'NextJump',
          'Sizes',
          'FullJump',
          'Total',
        ]"
        @page-change="handlePageforUserChange"
      />
    </el-dialog>
  </div>
</template>

<script>
import {
  GetOrganizationunitForTree,
  addRootOrganization,
  updateOrganization,
  deleteOrganization,
  getallOrganization,
  moveOrganization,
  getorginfobyid,
  getuseinorganizationunis,
} from "@/api/identity/organizationunit";
import {
  getuserlist,
  batchadduserToOrg,
  removeuserinOrg,
} from "@/api/identity/user";

import { mapGetters } from "vuex";
import moment from "moment";
import { checkPermission } from "@/utils/abp";
export default {
  name: "OrganizationUnit",
  data() {
    return {
      allorgdata: [],
      Treedata: [],
      defaultProps: {
        children: "children",
        label: "displayName",
      },
      // 新增
      dialogaddrootorgFormVisible: false, // 添加根组织弹窗
      addrootorfForm: {
        displayName: "",
        parentId: null,
        parentName: "",
      },
      addrootorgFormrules: {
        displayName: [
          { required: true, message: "请输入组织机构名称", trigger: "blur" },
        ],
      },
      // 修改
      dialogeditorgFormVisible: false,
      editrootorgForm: {
        displayName: "",
        id: "",
        parentName: "",
        parentId: null,
        updateparentId: "",
        concurrencyStamp: "",
      },
      editrootorgFormrules: {
        displayName: [
          { required: true, message: "请输入组织机构名称", trigger: "blur" },
        ],
      },
      showMenu: false,
      classname: {},
      currentchecknode: {}, // 当前选中的节点
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },
      orguserDataLit: [],
      // 添加组织成员弹窗控制显示与隐藏
      dialogaddorgUserFormVisible: false,
      tableforUserListPage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },
      userDataLit: [],
      selectedUserList: [], // 选中的用户
    };
  },
  computed: {
    ...mapGetters(["abpConfig"]),
    userinorgtitle() {
      if (Object.keys(this.currentchecknode).length == 0) {
        return "组织成员";
      } else {
        return "组织成员" + "(" + this.currentchecknode.displayName + ")";
      }
    },
    allorgdatapinjie() {
      const data = [];
      for (const i of this.allorgdata) {
        if (i.parentId != null) {
          const res = this.allorgdata.find((x) => x.id == i.parentId);
          if (res.constructor === Object) {
            i.parentName = res.displayName;
          }
        } else {
          i.parentName = "";
        }
        data.push(i);
      }
      console.log(data);
      return data;
    },
  },
  mounted() {
    document.body.addEventListener("click", () => {
      this.left();
    });
    // 监听滚动条滚动事件
    document.body.addEventListener("scroll", () => {
      this.left();
    });
    // 监听 el-scroller滚动条滚动事件
    const scrollbarEl = this.$refs.scrollbar.wrap;
    scrollbarEl.onscroll = () => {
      this.left();
    };
  },
  created() {
    this.getorganizationunit();
  },
  methods: {
    moment,
    checkPermission,
    // 获取组织树
    getorganizationunit() {
      GetOrganizationunitForTree().then((res) => {
        this.Treedata = res.items;
        this.$nextTick(() => {
          this.$refs.tree.setCurrentKey(this.currentchecknode.id);
        });
      });
    },
    // 获取所有的组织
    async getallOrganizationDatalist() {
      const res = await getallOrganization();
      this.allorgdata = res;
    },
    // 获取该组织下所有用户
    getuserinorglist() {
      const { currentPage, pageSize } = this.tablePage;
      const param = {
        ouId: this.currentchecknode.id,
        includeChildren: false,
        Sorting: "",
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      getuseinorganizationunis(param).then((res) => {
        this.orguserDataLit = res.items;
        this.tablePage.totalResult = res.totalCount;
      });
    },
    // tree节点事件
    nodeclick(data, node, tree) {
      this.currentchecknode = node.data;
      this.getuserinorglist();
      this.left();
    },
    // tree鼠标右键事件
    contextmenuhandler(param, data, node, tree) {
      this.currentchecknode = node.data;
      this.$nextTick(() => {
        this.$refs.tree.setCurrentKey(node.data.id);
      });
      this.showMenu = true;
      this.classname = {
        position: "fixed",
        "z-index": "2000",
        left: param.clientX + 5 + "px",
        top: param.clientY + 7 + "px",
      };
      this.getuserinorglist();
    },

    left() {
      this.showMenu = false;
      this.classname = {};
    },
    // 添加根组织
    addrootorg() {
      // this.addRootOrganization
      this.dialogaddrootorgFormVisible = true;
    },
    canceladdrootorgForm() {
      this.dialogaddrootorgFormVisible = false;
      this.$refs.addrootorgForm.resetFields();
      this.addrootorfForm.parentId = null;
      this.addrootorfForm.displayName = "";
      this.addrootorfForm.parentName = "";
    },
    // 添加组织
    confirmaddrootorgForm() {
      this.$refs.addrootorgForm.validate((valid) => {
        if (valid) {
          const param = {
            displayName: this.addrootorfForm.displayName,
          };
          if (this.addrootorfForm.parentId != null) {
            param.parentId = this.addrootorfForm.parentId;
          } else {
            // param.parentId = null;
          }
          addRootOrganization(param).then((res) => {
            this.$notify({
              title: "提示",
              message: "添加新组织结构成功",
              type: "success",
            });
            this.canceladdrootorgForm()
            this.getorganizationunit();
          });
        } else {
          return false;
        }
      });
    },
    // 添加子组织
    addchildorg() {
      this.addrootorfForm.parentId = this.currentchecknode.id;
      this.addrootorfForm.parentName = this.currentchecknode.displayName;
      this.dialogaddrootorgFormVisible = true;
    },
    // 修改组织信息
    async updatetreenode() {
      await this.getallOrganizationDatalist();
      const res = await getorginfobyid(this.currentchecknode.id);
      this.dialogeditorgFormVisible = true;

      this.editrootorgForm.concurrencyStamp = res.concurrencyStamp;
      this.editrootorgForm.id = res.id;
      this.editrootorgForm.parentId = res.parentId;

      this.editrootorgForm.displayName = res.displayName;
      this.editrootorgForm.updateparentId =
        this.currentchecknode.parentId == null
          ? this.currentchecknode.id
          : this.currentchecknode.parentId;
    },
    // 删除组织
    deleteorg() {
      this.$confirm("此操作将永久删除, 是否继续?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          deleteOrganization(this.currentchecknode.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "删除成功",
              type: "success",
            });
            this.currentchecknode = {};
            this.getorganizationunit();
          });
        })
        .catch(() => {});
    },
    // 修改组织信息弹窗取消
    canceleditorgForm() {
      this.dialogeditorgFormVisible = false;
      this.$refs.editrootorgForm.resetFields();
      this.editrootorgForm.displayName = "";
      this.editrootorgForm.id = "";
      this.editrootorgForm.parentName = "";
      this.editrootorgForm.parentId = null;
      this.editrootorgForm.updateparentId = "";
      this.editrootorgForm.concurrencyStamp = "";
    },
    // 修改组织信息弹窗确定
    confirmeditorgForm() {
      const res = this.editrootorgForm;
      const param = {
        id: this.editrootorgForm.id,
        parentId:
          this.editrootorgForm.updateparentId == ""
            ? null
            : this.editrootorgForm.updateparentId,
      };
      const param2 = {
        displayName: this.editrootorgForm.displayName,
        concurrencyStamp: this.editrootorgForm.concurrencyStamp,
      };
      if (param.id == param.parentId) {
        this.$notify({
          title: "提示",
          message: "当前组织不可移动到自己",
          type: "warning",
        });
      } else {
        this.$refs.editrootorgForm.validate((valid) => {
          if (valid) {
            updateOrganization(this.editrootorgForm.id, param2).then((res) => {
              moveOrganization(param).then((res) => {
                this.$notify({
                  title: "提示",
                  message: "修改成功",
                  type: "success",
                });
                this.canceleditorgForm()
                this.getorganizationunit();
              });
            });
          } else {
            return false;
          }
        });
      }
    },
    // 添加用户到组织弹窗显示
    adduserinorg() {
      this.dialogaddorgUserFormVisible = true;
      this.getuserDatalist();
    },
    getuserDatalist() {
      const { currentPage, pageSize } = this.tableforUserListPage;
      const param = {
        filter: "",
        Sorting: "",
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      getuserlist(param).then((res) => {
        this.userDataLit = res.items;
        this.tableforUserListPage.totalResult = res.totalCount;
      });
    },
    // table列勾选事件
    checkboxchange({ records, checked, row }) {
      if (checked == true) {
        // 选中
        this.selectedUserList.push(row);
      } else {
        // 取消选中
        this.selectedUserList.splice(
          this.selectedUserList.findIndex((x) => x.id == row.id),
          1
        );
      }
    },
    // table 列全选事件
    checkall({ records, checked }) {
      this.selectedUserList = [];
      this.selectedUserList.push(...records);
    },
    // 选择成员添加到组织弹窗关闭
    addorgUserdialogclose() {
      this.tableforUserListPage.currentPage = 1;
      this.tableforUserListPage.pageSize = 10;
      this.tableforUserListPage.totalResult = 0;
    },
    // 保存用户到组织按钮事件
    saveusertoorg() {
      const param = {
        userId: this.selectedUserList.map((item) => {
          return item.id;
        }),
        orgId: this.currentchecknode.id,
      };
      batchadduserToOrg(param).then((res) => {
        if (res == true) {
          this.$notify({
            title: "提示",
            message: "添加用户到组织成功",
            type: "success",
          });
          this.tableforUserListPage.currentPage = 1;
          this.tableforUserListPage.pageSize = 10;
          this.tableforUserListPage.totalResult = 0;
          this.dialogaddorgUserFormVisible = false;
          this.getuserinorglist();
          this.getorganizationunit();
        }
      });
    },
    // 删除该组织下的用户
    deleteuserinorg(userid) {
      const param = {
        UserId: userid,
        OrgId: this.currentchecknode.id,
      };
      this.$confirm("此操作将永久删除, 是否继续?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          removeuserinOrg(param).then((res) => {
            if (res == true) {
              this.$notify({
                title: "提示",
                message: "删除该组织下的用户成功",
                type: "success",
              });
              this.getuserinorglist();
              this.getorganizationunit();
            }
          });
        })
        .catch(() => {});
    },
    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.pageSize = pageSize;
      this.getuserinorglist();
    },
    handlePageforUserChange({ currentPage, pageSize }) {
      this.tableforUserListPage.currentPage = currentPage;
      this.tableforUserListPage.pageSize = pageSize;
      this.getuserDatalist();
    },
    checCheckboxkMethod({ row }) {
      return this.orguserDataLit.findIndex((x) => x.id == row.id) == -1;
    },
  },
};
</script>

<style scoped>
.rightmenu {
  float: right;
  display: flex;
  justify-content: flex-start;
  align-content: center;
  line-height: 1;
  font-size: 12px;
}
.btnaddroot {
  padding: 3px 0;
  font-size: 12px;
  font-family: "微软雅黑";
  line-height: 1;
}
.refresh-icon {
  padding: 3px 0;
  text-align: center;
  font-size: 14px;
  color: #66b1ff;
  cursor: pointer;
}
::v-deep .el-card__header {
  padding: 8px 10px;
  font-size: 13px;
  font-family: "微软雅黑";
}
.el-tree {
  padding-left: 20px;
}
.custom-tree-node {
  font-size: 12px;
  font-family: "宋体";
  height: 26px;
  line-height: 26px;
}
.node-icon-label {
  margin-left: 3px;
}
.orgcardscroller {
  height: calc(100vh - 204px);
}
.userinorgcardscroller {
  max-height: calc(100vh - 234px);
}
::v-deep
  .el-tree--highlight-current
  .el-tree-node.is-current
  > .el-tree-node__content {
  background-color: #1890ff;
}
::v-deep .el-tree-node__label {
  font-size: 12px;
}
::v-deep .el-scrollbar__wrap {
  overflow-x: hidden;
}
::v-deep .vxe-table--render-default {
  font-size: 12px;
}
.menu {
  color: black;
  background-color: #fff;
  box-shadow: 0 3px 6px -4px rgba(0, 0, 0, 0.12),
    0 6px 16px 0 rgba(0, 0, 0, 0.08), 0 9px 28px 8px rgba(0, 0, 0, 0.05);
  border-radius: 4px;
  /* padding: 0 14px; */
  text-align: left;
  margin: 0 auto;
  font-family: "微软雅黑";
  font-size: 12px;
}
ul {
  list-style-type: none;
  padding: 0px;
  margin: 6px 0;
}
li {
  height: 28px;
  padding: 0 14px;
  line-height: 28px;
}
ul li:hover {
  background-color: #eee;
  cursor: pointer;
}

::v-deep .el-scrollbar__wrap {
  margin-bottom: 0px !important;
}
.userinorgdialog {
  max-height: 450px;
}
</style>
