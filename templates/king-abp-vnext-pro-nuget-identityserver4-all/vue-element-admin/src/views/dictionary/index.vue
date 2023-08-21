<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <el-form :inline="true" :model="searchform" class="form-inline">
          <el-form-item>
            <el-input
              ref="refsearchform"
              v-model="searchform.filter"
              style="width: 500px"
              placeholder="请输入公告标题"
            />
          </el-form-item>
          <el-form-item>
            <el-button type="primary" @click="getdictionarylist"
              >查询</el-button
            >
          </el-form-item>
        </el-form>
      </template>
      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom>
          <template #buttons>
            <el-button
              v-if="checkPermission('Dictionary.Create')"
              type="primary"
              icon="el-icon-plus"
              @click="adddictionarydialogdisplay"
              >新增</el-button
            >
          </template>
        </vxe-toolbar>
        <vxe-table
          id="dictionary"
          :data="datalist"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
        >
          <vxe-table-column type="seq" width="60" />
          <vxe-table-column title="字典名称" min-width="150" field="name">
            <template v-slot="{ row }">
              <el-button @click="adddictionarydetail(row)" type="text">{{
                row.name
              }}</el-button>
            </template>
          </vxe-table-column>
          <vxe-table-column title="备注" min-width="100" field="description" />
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
              <el-button
                type="text"
                @click="editdictionary(row)"
                icon="el-icon-edit"
                >修改</el-button
              >
              <el-button
                type="text"
                @click="deletedictionary(row)"
                icon="el-icon-delete"
                >删除</el-button
              >
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
    <adddictionarydialog ref="refadddictionarydialog"></adddictionarydialog>
    <adddictionarydetaildialog
      ref="refadddictionarydetaildialog"
    ></adddictionarydetaildialog>
    <editdictionarydialog ref="refeditdictionarydialog"></editdictionarydialog>
  </div>
</template>

<script>
import {
  getdictionarypagelist,
  deletedictionaryinfo,
} from "@/api/dictionary/index";
import updowspanel from "@/components/MainView/updowspanel";
import moment from "moment";
import { mapGetters } from "vuex";
import { checkPermission } from "@/utils/abp";
import adddictionarydialog from "./dialog/adddictionarydialog";
import adddictionarydetaildialog from "./dialog/adddictionarydetaildialog";
import editdictionarydialog from "./dialog/editdictionarydialog";
export default {
  name: "Dictionary",
  components: {
    updowspanel,
    adddictionarydialog,
    adddictionarydetaildialog,
    editdictionarydialog,
  },
  data() {
    return {
      tableheight: 200,
      datalist: [],
      searchform: {
        filter: "",
      },
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },
    };
  },
  methods: {
    moment,
    checkPermission,
    getdictionarylist() {
      const { currentPage, pageSize } = this.tablePage;
      let param = {
        filter: this.searchform.filter,
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      getdictionarypagelist(param).then((res) => {
        this.datalist = res.items;
        this.tablePage.totalResult = res.totalCount;
      });
    },

    adddictionarydialogdisplay() {
      this.$refs.refadddictionarydialog.createdictionarydialog(
        this.getdictionarylist
      );
    },

    //修改字典
    editdictionary(row) {
      this.$refs.refeditdictionarydialog.editdictionarydialog(
        this.getdictionarylist,
        row.id
      );
    },

    deletedictionary(row) {
      this.$confirm("此操作将永久删除该文件, 是否继续?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          deletedictionaryinfo(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "删除字典成功",
              type: "success",
            });
            this.getdictionarylist();
          });
        })
        .catch(() => {});
    },
    //添加字典详情
    adddictionarydetail(row) {
      this.$refs.refadddictionarydetaildialog.createadddictionarydetaildialog(
        this.getdictionarylist,
        row.id
      );
    },

    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height;
      });
    },
    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.currentPage = currentPage;
      this.getdictionarylist();
    },
  },
  created() {
    this.getdictionarylist();
  },
};
</script>

<style>
</style>