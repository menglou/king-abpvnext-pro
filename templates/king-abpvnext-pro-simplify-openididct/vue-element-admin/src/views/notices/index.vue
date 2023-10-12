<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <el-form :inline="true" :model="searchform" class="form-inline">
          <el-form-item>
            <el-input
              ref="refsearchform"
              v-model="searchform.title"
              style="width: 500px"
              placeholder="请输入公告标题"
            />
          </el-form-item>
          <el-form-item>
            <el-button type="primary" @click="getnoticelist">查询</el-button>
          </el-form-item>
        </el-form>
      </template>
      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom>
          <template #buttons>
            <el-button
              v-if="checkPermission('AbpIdentity.Users.Create')"
              type="primary"
              icon="el-icon-plus"
              @click="addnoticedialogdisplay"
              >新增</el-button
            >
          </template>
        </vxe-toolbar>
        <vxe-table
          id="user"
          :data="datalist"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
        >
          <vxe-table-column type="seq" width="60" />
          <vxe-table-column title="公告标题" min-width="100" field="title" />
          <vxe-table-column
            title="内容"
            show-overflow
            min-width="200"
            field="content"
          />
          <vxe-table-column title="状态" min-width="100" field="status">
            <template v-slot="{ row }">
              <el-tag type="success" v-if="row.status == 0">正常</el-tag>
              <el-tag type="success" v-else>关闭</el-tag>
            </template>
          </vxe-table-column>
          <vxe-table-column
            title="创建时间"
            min-width="150"
            field="creationTime"
          >
            <template v-slot="{ row }">
              {{ moment(row.creationTime).format("YYYY-MM-DD") }}
            </template>
          </vxe-table-column>
          <vxe-table-column title="操作" min-width="80">
            <template v-slot="{ row }">
              <el-dropdown>
                <span class="el-dropdown-link">
                  操作<i class="el-icon-arrow-down el-icon--right" />
                </span>
                <el-dropdown-menu slot="dropdown">
                  <el-dropdown-item
                    v-if="checkPermission('AbpIdentity.Users.Delete')"
                    v-show="row.isSend == false"
                    class="dropdown-item"
                    icon="el-icon-bell"
                    @click.native="notice(row.id)"
                    >通知
                  </el-dropdown-item>
                  <el-dropdown-item
                    v-if="checkPermission('AbpIdentity.Users.Update')"
                    class="dropdown-item"
                    icon="el-icon-edit"
                    @click.native="modifynotice(row)"
                    >修改</el-dropdown-item
                  >
                  <el-dropdown-item
                    v-if="
                      checkPermission('AbpIdentity.Users.ManagePermissions')
                    "
                    class="dropdown-item"
                    icon="el-icon-delete"
                    @click.native="deletenotice(row.id)"
                    >删除</el-dropdown-item
                  >
                </el-dropdown-menu>
              </el-dropdown>
            </template>
          </vxe-table-column>
        </vxe-table>
        <vxe-pager
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
      </template>
    </updowspanel>
    <addnoticedialog ref="refaddnoticedialog"></addnoticedialog>
    <editnoticedialog ref="refeditnoticedialog"></editnoticedialog>
  </div>
</template>

<script>
import updowspanel from "@/components/MainView/updowspanel";
import addnoticedialog from "./dialog/addnoticedialog";
import editnoticedialog from "./dialog/editnoticedialog.vue";
import moment from "moment";
import { mapGetters } from "vuex";
import { checkPermission } from "@/utils/abp";
import {
  getnoticepagelist,
  onlysendnotice,
  deleteBroadCastnotice,
} from "@/api/notcie";
export default {
  components: {
    updowspanel,
    addnoticedialog,
    editnoticedialog,
  },
  name: "Notice",
  data() {
    return {
      tableheight: 200,
      datalist: [],
      searchform: {
        title: "",
      },
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },
    };
  },
  methods: {
    checkPermission,
    moment,
    getnoticelist() {
      const { currentPage, pageSize } = this.tablePage;
      let param = {
        Status: 0,
        Title: this.searchform.title,
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      getnoticepagelist(param).then((res) => {
        this.datalist = res.items;
        this.tablePage.totalResult = res.totalCount;
      });
    },
    //发布通知
    notice(id) {
      onlysendnotice(id).then(() => {
        this.$notify({
          title: "提示",
          message: "通告发布成功",
          type: "success",
        });
        this.getnoticelist();
      });
    },
    addnoticedialogdisplay() {
      this.$refs.refaddnoticedialog.createaddnoticedialog(this.getnoticelist);
    },
    modifynotice(row) {
      this.$refs.refeditnoticedialog.createeditnoticedialog(
        this.getnoticelist,
        row
      );
    },
    deletenotice(id) {
      this.$confirm("此操作将永久删除该文件, 是否继续?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          deleteBroadCastnotice(id).then(() => {
            this.$message({
              type: "success",
              message: "删除成功!",
            });
            this.getnoticelist();
          });
        })
        .catch(() => {});
    },

    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.currentPage = currentPage;
      this.getnoticelist();
    },
    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height;
      });
    },
  },
  created() {
    this.getnoticelist();
  },
};
</script>

<style>
</style>