<template>
  <div>
    <vxe-modal
      v-model="schedulelogdialogVisible"
      title="查看日志"
      :position="{ top: 120 }"
      width="1200"
      @close="schedulelogmodalclose"
    >
      <div class="dialogcontrainer">
        <el-form :inline="true" :model="seacrh" class="demo-form-inline">
          <el-form-item label="日期范围">
            <el-date-picker
              v-model="seacrh.daterange"
              type="daterange"
              range-separator="至"
              start-placeholder="开始日期"
              :clearable="false"
              end-placeholder="结束日期"
              value-format="yyyy-MM-dd"
            >
            </el-date-picker>
          </el-form-item>
          <el-form-item>
            <el-button type="primary" @click="getdatalist">查询</el-button>
          </el-form-item>
        </el-form>
        <vxe-table
          id="user"
          :data="scheduledatalist"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
        >
          <vxe-table-column type="seq" width="60" fixed="left" />
          <vxe-table-column title="任务名称" min-width="180" field="jobName" />
          <vxe-table-column title="任务状态" min-width="150" field="status">
            <template v-slot="{ row }">
              <el-tag type="success" v-if="row.status == 0">正常</el-tag>
              <el-tag type="danger" v-else-if="row.status == 1">失败</el-tag>
            </template>
          </vxe-table-column>
          <vxe-table-column
            title="执行用时，毫秒"
            min-width="100"
            field="elapsed"
          />
          <vxe-table-column
            title="上次运行时间"
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
          <vxe-table-column
            title="任务返回信息"
            min-width="180"
            field="jobMessage"
            show-overflow="tooltip"
          />
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
      </div>
    </vxe-modal>
  </div>
</template>

<script>
import { getschedulelogpagelist } from "@/api/scheduletask/index";
import moment from "moment";
export default {
  data() {
    return {
      callbackmethod: null,
      schedulelogdialogVisible: false,
      scheduledatalist: [],
      scheduleId: "",
      seacrh: {
        daterange: [],
        beginDate: "",
        endDate: "",
      },
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },
      tableheight: 560,
    };
  },
  methods: {
    moment,
    createschedulelogdialog(cb, id) {
      this.callbackmethod = cb;
      this.scheduleId = id;
      this.schedulelogdialogVisible = true;
      this.getdatalist();
    },
    getdatalist() {
      const { currentPage, pageSize } = this.tablePage;
      const param = {
        scheduleId: this.scheduleId,
        StartTime:
          this.seacrh.daterange[0] != null
            ? this.seacrh.daterange[0] + " 00:00:00"
            : this.seacrh.daterange[0],
        EndTime: this.seacrh.daterange[1] != null
            ? this.seacrh.daterange[1] + " 23:59:59"
            : this.seacrh.daterange[1],
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      getschedulelogpagelist(param).then((res) => {
        this.scheduledatalist = res.items;
        this.tablePage.totalResult = res.totalCount;
      });
    },
    schedulelogmodalclose() {
      this.callbackmethod = null;
      this.scheduledatalist = [];
      this.schedulelogdialogVisible = false;
    },
    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.pageSize = pageSize;
      this.getdatalist();
    },
  },
};
</script>

<style scoped>
.dialogcontrainer {
  margin-top: 15px;
  margin-right: 15px;
  margin-left: 15px;
}
.form {
  margin-top: 15px;
  margin-right: 15px;
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
</style>