<template>
  <vxe-modal
    v-model="binduserdialogFormVisible"
    type="modal "
    title="绑定用户"
    :position="{ top: 40 }"
    width="950"
    @close="bindusermodalclose"
  >
    <div class="header-bind">
      <template>
        <div class="header-toolbar">
          <el-button
            size="small"
            icon="el-icon-plus"
            type="primary"
            @click="saveposterUser"
            >保存</el-button
          >
        </div>
      </template>
      <vxe-table
        id="posterUser"
        ref="refposterUser"
        :data="userDataList"
        class="posterUserdialog"
        auto-resize
        max-height="450"
        align="center"
        :custom-config="{ storage: true }"
        border="inner"
        :row-config="{ keyField: 'id' }"
        @checkbox-change="checkboxchange"
        @checkbox-all="checkall"
      >
        >
        <vxe-column type="checkbox" width="60" />
        <vxe-table-column type="seq" width="60" />
        <vxe-table-column v-if="false" field="id" width="60" />
        <vxe-table-column width="240" title="是否已经绑定该岗位">
          <template v-slot="{ row }">
            <template
              v-if="posterUserDataList.findIndex((x) => x.id == row.id) != -1"
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
    </div>
  </vxe-modal>
</template>

<script>
import {getposteruserbyid,batchbinduserposter} from "@/api/poster/index";
import { getuserlist } from "@/api/identity/user";
export default {
  data() {
    return {
      callbackmethod: null,
      binduserdialogFormVisible: false,
      id: "",
      userDataList: [],
      posterUserDataList: [],
      selectedUserList: [], // 选中的用户
      tableforUserListPage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },
    };
  },
  methods: {
    async binduserdialog(cb, row) {
      this.callbackmethod = cb;
      this.binduserdialogFormVisible = true;
      this.id = row.id;
      this.posterUserDataList = await getposteruserbyid(this.id);
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
        this.userDataList = res.items;
        this.tableforUserListPage.totalResult = res.totalCount;
        this.setUserCheckboxRow();
      });
    },
    // 保存用户按钮事件
    saveposterUser() {
      const param = {
        userId: this.selectedUserList.map((item) => {
          return item.id;
        }),
        posterId: this.id,
      };
      batchbinduserposter(param).then((res) => {
        if (res == true) {
          this.$notify({
            title: "提示",
            message: "绑定用户成功",
            type: "success",
          });
          this.callbackmethod();
          this.bindusermodalclose();
        }
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
    bindusermodalclose() {
      this.callbackmethod = null;
      this.tableforUserListPage.currentPage = 1;
      this.tableforUserListPage.pageSize = 10;
      this.tableforUserListPage.totalResult = 0;
      this.selectedUserList = [];
      this.userDataList = [];
      this.posterUserDataList = [];
      this.binduserdialogFormVisible = false;
    },
    setUserCheckboxRow() {
      this.userDataList.forEach((e) => {
        if (this.posterUserDataList.find((x) => x.id == e.id)) {
          this.$refs.refposterUser.setCheckboxRow(e, true);
          this.selectedUserList.push(e);
        }
      });
    },
    handlePageforUserChange({ currentPage, pageSize }) {
      this.tableforUserListPage.currentPage = currentPage;
      this.tableforUserListPage.pageSize = pageSize;
      this.getuserDatalist();
    },
    checCheckboxkMethod({ row }) {
      return this.posterUserDataList.findIndex((x) => x.id == row.id) == -1;
    },
  },
};
</script>

<style scoped>
.header-bind {
  padding: 10px 20px;
}
</style>
