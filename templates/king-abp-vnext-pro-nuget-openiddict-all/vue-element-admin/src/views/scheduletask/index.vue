<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <el-form :inline="true" :model="searchform" class="form-inline">
          <el-form-item>
            <el-input
              ref="refsearchform"
              v-model="searchform.jobName"
              style="width: 500px"
              placeholder="请输入计划任务名称"
            />
          </el-form-item>
          <el-form-item>
            <el-button
              type="primary"
              v-if="checkPermission('ScheduleTaskManager.ScheduleTask')"
              @click="getschedulelist"
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
              v-if="checkPermission('ScheduleTaskManager.ScheduleTask.Create')"
              @click="adddscheduletaskdialogdisplay"
              >新增任务</el-button
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
          <vxe-table-column title="任务名称" min-width="150" field="title">
            <template v-slot="{ row }">
              <el-button type="text">{{ row.title }}</el-button>
            </template>
          </vxe-table-column>
          <vxe-table-column title="任务分组" min-width="150" field="jobGroup" />
          <vxe-table-column title="任务类型" min-width="150" field="jobType">
            <template v-slot="{ row }">
              <label v-if="row.jobType == 1">Http任务</label>
              <label v-else-if="row.jobType == 2">程序集任务</label>
            </template>
          </vxe-table-column>
          <vxe-table-column title="运行模式" min-width="150" field="runLoop">
            <template v-slot="{ row }">
              {{ row.runLoop ? "周期运行" : "一次运行" }}
            </template>
          </vxe-table-column>
          <vxe-table-column title="开始时间" min-width="150" field="startDate">
            <template v-slot="{ row }">
              {{
                row.startDate != null
                  ? moment(row.startDate).format("YYYY-MM-DD HH:mm:ss")
                  : "-"
              }}
            </template>
          </vxe-table-column>
          <vxe-table-column
            title="上次运行时间"
            min-width="180"
            field="lastRunTime"
          >
            <template v-slot="{ row }">
              {{
                row.lastRunTime != null
                  ? moment(row.lastRunTime).format("YYYY-MM-DD HH:mm:ss")
                  : "-"
              }}
            </template>
          </vxe-table-column>
          <vxe-table-column
            title="下次运行时间"
            min-width="180"
            field="nextRunTime"
          >
            <template v-slot="{ row }">
              {{
                row.nextRunTime != null
                  ? moment(row.nextRunTime).format("YYYY-MM-DD HH:mm:ss")
                  : "-"
              }}
            </template>
          </vxe-table-column>
          <vxe-table-column
            title="运行次数"
            min-width="150"
            field="totalRunCount"
          />
          <vxe-table-column title="任务状态" min-width="150" field="status">
            <template v-slot="{ row }">
              <el-tag type="danger" v-if="row.status == 0">已停止</el-tag>
              <el-tag type="success" v-else-if="row.status == 1">运行中</el-tag>
              <el-tag type="warning" v-else>已暂停</el-tag>
            </template>
          </vxe-table-column>
          <vxe-table-column title="备注" min-width="150" field="remark" />
          <vxe-table-column title="操作" min-width="200" fixed="right">
            <template v-slot="{ row }">
              <el-button class="btn-cz" @click="showschedulelog(row)"
                >日志</el-button
              >
              <el-button
                class="btn-cz"
                v-if="
                  row.status == 0 &&
                  checkPermission('ScheduleTaskManager.ScheduleTask.Update')
                "
                @click="editscheduletask(row)"
                >编辑</el-button
              >
              <el-button
                class="btn-cz"
                type="warning"
                v-if="
                  row.status == 1 &&
                  checkPermission('ScheduleTaskManager.ScheduleTask.Pause')
                "
                @click="pausescheduletask(row)"
                >暂停</el-button
              >
              <el-button
                class="btn-cz"
                type="primary"
                v-if="
                  row.status == 0 &&
                  checkPermission('ScheduleTaskManager.ScheduleTask.Start')
                "
                @click="startscheduletask(row)"
                >启动</el-button
              >
              <el-button
                class="btn-cz"
                type="primary"
                v-if="
                  row.status == 1 &&
                  checkPermission('ScheduleTaskManager.ScheduleTask.RunOnce')
                "
                @click="runoncescheduletask(row)"
                >运行</el-button
              >
              <el-button
                class="btn-cz"
                type="success"
                v-if="
                  row.status != 0 &&
                  row.status != 1 &&
                  checkPermission('ScheduleTaskManager.ScheduleTask.Resume')
                "
                @click="resumescheduletask(row)"
                >恢复</el-button
              >
              <el-button
                class="btn-cz"
                type="danger"
                v-if="
                  row.status == 0 &&
                  checkPermission('ScheduleTaskManager.ScheduleTask.Delete')
                "
                @click="deletescheduletask(row)"
                >删除</el-button
              >
              <el-button
                class="btn-cz"
                type="danger"
                v-if="
                  row.status != 0 &&
                  checkPermission('ScheduleTaskManager.ScheduleTask.Stop')
                "
                @click="stopscheduletask(row)"
                >停止</el-button
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
    <addscheduletaskdialog
      ref="refaddscheduletaskdialog"
    ></addscheduletaskdialog>
    <editscheduletaskdialog
      ref="refeditscheduletaskdialog"
    ></editscheduletaskdialog>
    <schedulelogdialog ref="refschedulelogdialog"></schedulelogdialog>
  </div>
</template>

<script>
import {
  getscheduletaskpagelist,
  pausescheduletask,
  startscheduletask,
  runoncescheduletask,
  resumescheduletask,
  stopscheduletask,
  deletescheduletask,
} from "@/api/scheduletask/index";
import addscheduletaskdialog from "./dialog/addscheduletaskdialog";
import editscheduletaskdialog from "./dialog/editscheduletaskdialog";
import schedulelogdialog from "./dialog/schedulelogdialog";
import updowspanel from "@/components/MainView/updowspanel";
import moment from "moment";
import { mapGetters } from "vuex";
import { checkPermission } from "@/utils/abp";
export default {
  name: "ScheduleTask",
  components: {
    updowspanel,
    addscheduletaskdialog,
    editscheduletaskdialog,
    schedulelogdialog,
  },
  data() {
    return {
      tableheight: 200,
      datalist: [],
      searchform: {
        jobName: "",
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
    getschedulelist() {
      const { currentPage, pageSize } = this.tablePage;
      let param = {
        JobName: this.searchform.jobName,
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      getscheduletaskpagelist(param).then((res) => {
        this.datalist = res.items;
        this.tablePage.totalResult = res.totalCount;
      });
    },

    //新增任务
    adddscheduletaskdialogdisplay() {
      this.$refs.refaddscheduletaskdialog.createscheduletaskdialog(
        this.getschedulelist
      );
    },
    //编辑任务
    editscheduletask(row) {
      this.$refs.refeditscheduletaskdialog.createeditscheduletaskdialog(
        this.getschedulelist,
        row.id
      );
    },
    //暂停任务
    pausescheduletask(row) {
      this.$confirm("确定要暂停【" + row.title + "】?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          pausescheduletask(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "任务暂停成功",
              type: "success",
            });
            this.getschedulelist();
          });
        })
        .catch(() => {});
    },

    //启动任务
    startscheduletask(row) {
      this.$confirm("确定要启动【" + row.title + "】?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          startscheduletask(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "任务启动成功",
              type: "success",
            });
            this.getschedulelist();
          });
        })
        .catch(() => {});
    },

    //运行任务
    runoncescheduletask(row) {
      this.$confirm("确定要立即运行【" + row.title + "】?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          runoncescheduletask(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "任务运行成功",
              type: "success",
            });
            this.getschedulelist();
          });
        })
        .catch(() => {});
    },

    //回复任务
    resumescheduletask(row) {
      this.$confirm("确定要恢复【" + row.title + "】?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          resumescheduletask(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "任务恢复成功",
              type: "success",
            });
            this.getschedulelist();
          });
        })
        .catch(() => {});
    },

    //删除任务
    deletescheduletask(row) {
      this.$confirm("确定要删除【" + row.title + "】?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          deletescheduletask(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "任务删除成功",
              type: "success",
            });
            this.getschedulelist();
          });
        })
        .catch(() => {});
    },

    //停止任务
    stopscheduletask(row) {
      this.$confirm("确定要停止【" + row.title + "】?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          stopscheduletask(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "任务停止成功",
              type: "success",
            });
            this.getschedulelist();
          });
        })
        .catch(() => {});
    },

    //打开日志
    showschedulelog(row) {
      this.$refs.refschedulelogdialog.createschedulelogdialog(
        this.getschedulelist,
        row.id
      );
    },

    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.pageSize = pageSize;
      this.getschedulelist();
    },

    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height;
      });
    },
  },
  created() {
    this.getschedulelist();
  },
};
</script>

<style scoped>
.btn-cz {
  font-size: 11px;
  position: relative;
  display: inline-block;
  padding: 7px 7px;
  margin-left: 5px;
}
</style>