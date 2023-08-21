<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight" :ispager="false">
      <template slot="up">
        <el-form :inline="true" :model="searchform" class="form-inline">
          <el-form-item>
            <el-input
              ref="refsearchform"
              v-model="searchform.displayName"
              style="width: 500px"
              placeholder="请输入部门名称"
            />
          </el-form-item>
          <el-form-item>
            <el-button
              type="primary"
              v-if="checkPermission('Institution.DepartmentUnit')"
              @click="getdepartmentlist"
              >查询</el-button
            >
          </el-form-item>
        </el-form>
      </template>
      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom>
          <template #buttons>
            <el-button
              type="primary"
              icon="el-icon-plus"
              v-if="checkPermission('Institution.DepartmentUnit.Create')"
              @click="adddepartmentdialogdisplay"
              >新增根部门</el-button
            >
            <el-button type="primary" @click="expandAllTreeEvent"
              >展开所有</el-button
            >
            <el-button type="primary" @click="closeExpandTreeEvent"
              >关闭所有展开</el-button
            >
          </template>
        </vxe-toolbar>
        <vxe-table
          id="departmrntunit"
          :data="datalist"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
          ref="tableRef"
          :tree-config="{
            expandAll: true,
            transform: true,
            rowField: 'id',
            parentField: 'parentId',
          }"
        >
          <vxe-table-column type="seq" width="60" />
          <vxe-table-column
            title="部门名称"
            min-width="150"
            field="displayName"
            tree-node
          />
          <vxe-table-column title="部门编码" min-width="150" field="code" />
          <vxe-table-column
            title="创建时间"
            min-width="180"
            field="creationTime"
          >
            <template v-slot="{ row }">
              {{
                row.creationTime != null
                  ? moment(row.creationTime).format("YYYY-MM-DD HH:mm:ss")
                  : "-"
              }}
            </template>
          </vxe-table-column>
          <vxe-table-column title="操作" min-width="200">
            <template v-slot="{ row }">
              <el-button
                style="color: #409eff"
                icon="el-icon-edit"
                type="text"
                v-if="checkPermission('Institution.DepartmentUnit.Update')"
                @click="editdepartment(row)"
                >编辑</el-button
              >
              <el-button
                type="text"
                style="color: #ff8040"
                v-if="checkPermission('Institution.DepartmentUnit.Create')"
                @click="addsubdepartment(row)"
              >
                <svg-icon icon-class="tree" />
                添加子部门
              </el-button>
              <el-button
                type="text"
                v-if="checkPermission('Institution.DepartmentUnit.Delete')"
                @click="deletedepartment(row)"
                style="color: #f56c6c"
                icon="el-icon-delete"
                >删除</el-button
              >
              <el-button
                type="text"
                v-if="checkPermission('Institution.DepartmentUnit.BindUser')"
                @click="binduser(row)"
                style="color: #67c23a"
                icon="el-icon-link"
                >绑定用户</el-button
              >
            </template>
          </vxe-table-column>
        </vxe-table>
      </template>
    </updowspanel>

    <adddeparmentdialog ref="refadddeparmentdialog"></adddeparmentdialog>
    <updatedeparmentdialog
      ref="refupdatedeparmentdialog"
    ></updatedeparmentdialog>
    <binduserdialog ref="refbinduserdialog"></binduserdialog>
  </div>
</template>

<script>
import { getalldepartmentUnit, deletedepartment } from "@/api/department/index";
import adddeparmentdialog from "./dialog/adddeparmentdialog";
import updatedeparmentdialog from "./dialog/updatedeparmentdialog";
import binduserdialog from "./dialog/binduserdialog";
import moment from "moment";
import updowspanel from "@/components/MainView/updowspanel";
import { checkPermission } from "@/utils/abp";
export default {
  name: "DepartmentUnit",
  components: {
    updowspanel,
    adddeparmentdialog,
    updatedeparmentdialog,
    binduserdialog,
  },
  data() {
    return {
      tableheight: 600,
      searchform: {
        displayName: "",
      },
      datalist: [],
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
    getdepartmentlist() {
      let param = {
        Filter: this.searchform.displayName,
      };
      getalldepartmentUnit(param).then((res) => {
        this.datalist = res;
        this.$nextTick(() => this.$refs.tableRef.setAllTreeExpand(true));
      });
    },
    //新增部门
    adddepartmentdialogdisplay() {
      this.$refs.refadddeparmentdialog.createdepartmentdialog(
        this.getdepartmentlist,
        null
      );
    },
    //新增子部门
    addsubdepartment(row) {
      this.$refs.refadddeparmentdialog.createdepartmentdialog(
        this.getdepartmentlist,
        row
      );
    },
    //编辑部门
    editdepartment(row) {
      this.$refs.refupdatedeparmentdialog.editdepartmentdialog(
        this.getdepartmentlist,
        row
      );
    },
    //删除部门
    deletedepartment(row) {
      this.$confirm("确定要删除【" + row.displayName + "】?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          deletedepartment(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "部门删除成功",
              type: "success",
            });
            this.getdepartmentlist();
          });
        })
        .catch(() => {});
    },

    //绑定用户
    binduser(row) {
      this.$refs.refbinduserdialog.binduserdialog(this.getdepartmentlist, row);
    },
    //展开所有树
    expandAllTreeEvent() {
      this.$refs.tableRef.setAllTreeExpand(true);
    },
    //关闭所有树展开
    closeExpandTreeEvent() {
      this.$refs.tableRef.clearTreeExpand();
    },

    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height;
      });
    },
  },
  created() {
    this.getdepartmentlist();
  },
};
</script>

<style scoped>
</style>