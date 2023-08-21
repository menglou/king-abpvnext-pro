<template>
  <div>
    <updowspanel :ispager="false" @setTableHeight="setTableHeight">
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
              v-if="checkPermission('Institution.DepartmentUnit')"
              type="primary"
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
              v-if="checkPermission('Institution.DepartmentUnit.Create')"
              type="primary"
              icon="el-icon-plus"
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
          ref="tableRef"
          :data="datalist"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
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
                v-if="checkPermission('Institution.DepartmentUnit.Update')"
                type="text"
                @click="editdepartment(row)"
                >编辑</el-button
              >
              <el-button
                v-if="checkPermission('Institution.DepartmentUnit.Create')"
                style="color:#FF8040"
                type="text"
                @click="addsubdepartment(row)"
              >
                <svg-icon icon-class="tree" />
                添加子部门
              </el-button>
              <el-button
                v-if="checkPermission('Institution.DepartmentUnit.Delete')"
                type="text"
                @click="deletedepartment(row)"
                style="color: #f56c6c"
                icon="el-icon-delete"
                >删除</el-button
              >
              <el-button
                v-if="checkPermission('Institution.DepartmentUnit.BindUser')"
                type="text"
                style="color: #67c23a"
                icon="el-icon-link"
                @click="binduser(row)"
                >绑定用户</el-button
              >
            </template>
          </vxe-table-column>
        </vxe-table>
      </template>
    </updowspanel>

    <adddeparmentdialog ref="refadddeparmentdialog" />
    <updatedeparmentdialog ref="refupdatedeparmentdialog" />
    <binduserdialog ref="refbinduserdialog" />
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
  created() {
    this.getdepartmentlist();
  },
  methods: {
    moment,
    checkPermission,
    getdepartmentlist() {
      const param = {
        Filter: this.searchform.displayName,
      };
      getalldepartmentUnit(param).then((res) => {
        this.datalist = res;
        this.$nextTick(() => this.$refs.tableRef.setAllTreeExpand(true));
      });
    },
    // 新增部门
    adddepartmentdialogdisplay() {
      this.$refs.refadddeparmentdialog.createdepartmentdialog(
        this.getdepartmentlist,
        null
      );
    },
    // 新增子部门
    addsubdepartment(row) {
      this.$refs.refadddeparmentdialog.createdepartmentdialog(
        this.getdepartmentlist,
        row
      );
    },
    // 编辑部门
    editdepartment(row) {
      this.$refs.refupdatedeparmentdialog.editdepartmentdialog(
        this.getdepartmentlist,
        row
      );
    },
    // 删除部门
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

    // 绑定用户
    binduser(row) {
      this.$refs.refbinduserdialog.binduserdialog(this.getdepartmentlist, row);
    },
    // 展开所有树
    expandAllTreeEvent() {
      this.$refs.tableRef.setAllTreeExpand(true);
    },
    // 关闭所有树展开
    closeExpandTreeEvent() {
      this.$refs.tableRef.clearTreeExpand();
    },

    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height;
      });
    },
  },
};
</script>

<style scoped>
</style>
