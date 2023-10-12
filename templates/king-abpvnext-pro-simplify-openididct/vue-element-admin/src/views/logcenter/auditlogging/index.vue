<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <vxe-form :data="queryForm" title-align="right" title-width="100">
          <vxe-form-item :title="$t('AbpAuditLogging[\'Url\']')" span="6">
            <template #default="{ data }">
              <vxe-input
                style="width: 320px"
                v-model="data.url"
                :placeholder="$t('AbpAuditLogging[\'PlaceholderInput\']')"
                clearable
              ></vxe-input>
            </template>
          </vxe-form-item>
          <vxe-form-item
            :title="$t('AbpAuditLogging[\'HttpMethod\']')"
            span="6"
          >
            <template #default="{ data }">
              <el-select
                v-model="data.httpMethod"
                clearable
                style="width: 320px"
              >
                <el-option label="获取(GET)" value="GET"></el-option>
                <el-option label="修改(PUT)" value="PUT"></el-option>
                <el-option label="提交(POST)" value="POST"></el-option>
                <el-option label="删除(DELETE)" value="DELETE"></el-option>
              </el-select>
            </template>
          </vxe-form-item>
          <vxe-form-item :title="$t('AbpAuditLogging[\'UserName\']')" span="6">
            <template #default="{ data }">
              <vxe-input
                style="width: 320px"
                v-model="data.userName"
                :placeholder="$t('AbpAuditLogging[\'PlaceholderInput\']')"
                clearable
              ></vxe-input>
            </template>
          </vxe-form-item>
          <vxe-form-item
            :title="$t('AbpAuditLogging[\'TenantName\']')"
            span="6"
          >
            <template #default="{ data }">
              <vxe-input
                style="width: 320px"
                v-model="data.tenantName"
                :placeholder="$t('AbpAuditLogging[\'PlaceholderInput\']')"
                clearable
              ></vxe-input>
            </template>
          </vxe-form-item>
          <vxe-form-item
            :title="$t('AbpAuditLogging[\'ClientIpAddress\']')"
            span="6"
            folding
          >
            <template #default="{ data }">
              <vxe-input
                style="width: 320px"
                v-model="data.clientIpAddress"
                :placeholder="$t('AbpAuditLogging[\'PlaceholderInput\']')"
                clearable
              ></vxe-input>
            </template>
          </vxe-form-item>
          <vxe-form-item
            :title="$t('AbpAuditLogging[\'HttpStatusCode\']')"
            span="6"
            folding
          >
            <template #default="{ data }">
              <el-select
                v-model="data.httpStatusCode"
                clearable
                style="width: 320px"
              >
                <el-option label="成功(200)" value="200" />
                <el-option label="未登录(401)" value="401" />
                <el-option label="未授权(403)" value="403" />
                <el-option label="未找到资源(404)" value="404" />
                <el-option label="异常(500)" value="500" />
              </el-select>
            </template>
          </vxe-form-item>
          <vxe-form-item
            :title="$t('AbpAuditLogging[\'ExecutionDuration\']')"
            span="6"
            folding
          >
            <template #default="{ data }">
              <vxe-input
                style="width: 320px"
                v-model="data.executionDuration"
                :placeholder="$t('AbpAuditLogging[\'PlaceholderInput\']')"
                clearable
              ></vxe-input>
            </template>
          </vxe-form-item>
          <vxe-form-item
            :title="$t('AbpAuditLogging[\'ApplicationName\']')"
            span="6"
            folding
          >
            <template #default="{ data }">
              <vxe-input
                style="width: 320px"
                v-model="data.applicationName"
                :placeholder="$t('AbpAuditLogging[\'PlaceholderInput\']')"
                clearable
              ></vxe-input>
            </template>
          </vxe-form-item>
          <vxe-form-item title="日期" span="6" folding>
            <template #default="{ data }">
              <el-date-picker
                v-model="data.queryDateTime"
                type="datetimerange"
                align="right"
                unlink-panels
                :picker-options="pickerOptions"
                :range-separator="$t('AbpAuditLogging[\'RangeSeparator\']')"
                :start-placeholder="$t('AbpAuditLogging[\'StartPlaceholder\']')"
                :end-placeholder="$t('AbpAuditLogging[\'EndPlaceholder\']')"
                value-format="yyyy-MM-ddTHH:mm:ss"
              />
            </template>
          </vxe-form-item>
          <vxe-form-item align="right" span="24" collapse-node>
            <template #default>
              <vxe-button @click="resetQueryForm">重置</vxe-button>
              <vxe-button status="primary" @click="getList">查询</vxe-button>
            </template>
          </vxe-form-item>
        </vxe-form>
      </template>
      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom> </vxe-toolbar>
        <vxe-table
          :data="datalist"
          id="audilog"
          auto-resize
          align="center"
          resizable
          :column-config="{ resizable: true }"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
        >
          <vxe-table-column type="seq" width="60"></vxe-table-column>
          <vxe-table-column
            width="130"
            title="状态码"
            min-width="80"
            field="httpStatusCode"
          >
            <template slot-scope="{ row }">
              <el-tag :type="row.httpStatusCode | requestStatusCode">
                {{ row.httpStatusCode }}
              </el-tag>
            </template>
          </vxe-table-column>
          <vxe-table-column
            width="140"
            min-width="100"
            title="请求方法"
            field="httpMethod"
          >
            <template slot-scope="{ row }">
              <el-tag
                :type="row.httpMethod | requestMethodFilter(row.httpMethod)"
              >
                {{ row.httpMethod }}
              </el-tag>
            </template>
          </vxe-table-column>

          <vxe-table-column
            title="耗时(毫秒)"
            min-width="130"
            field="executionDuration"
          >
            <template slot-scope="{ row }">
              <el-tag
                effect="dark"
                :type="row.executionDuration | requestDurationFilter"
              >
                {{ row.executionDuration }}ms
              </el-tag>
            </template>
          </vxe-table-column>
          <vxe-table-column
            min-width="180"
            title="请求地址"
            field="url"
            show-overflow
          >
            <template slot-scope="{ row }">
              {{ row.url }}
            </template>
          </vxe-table-column>

          <vxe-table-column
            min-width="140"
            :title="$t('AbpAuditLogging[\'UserName\']')"
            field="userName"
          >
            <template slot-scope="{ row }">
              <span>{{ row.userName | empty }}</span>
            </template>
          </vxe-table-column>
          <vxe-table-column
            min-width="140"
            :title="$t('AbpAuditLogging[\'TenantName\']')"
            field="tenantName"
          >
            <template slot-scope="{ row }">
              <span>{{ row.tenantName | empty }}</span>
            </template>
          </vxe-table-column>
          <vxe-table-column
            min-width="160"
            :title="$t('AbpAuditLogging[\'ExecutionTime\']')"
            field="executionTime"
          >
            <template slot-scope="{ row }">
              {{ moment(row.executionTime).format("YYYY-MM-DD HH:mm:ss") }}
            </template>
          </vxe-table-column>
          <vxe-table-column
            min-width="160"
            :title="$t('AbpAuditLogging[\'ApplicationName\']')"
            field="applicationName"
          >
            <template slot-scope="{ row }">
              <span>{{ row.applicationName | empty }}</span>
            </template>
          </vxe-table-column>
          <vxe-table-column
            min-width="160"
            :title="$t('AbpAuditLogging[\'ClientIpAddress\']')"
            field="clientIpAddress"
          >
            <template slot-scope="{ row }">
              <span>{{ row.clientIpAddress | empty }}</span>
            </template>
          </vxe-table-column>
          <vxe-table-column
            min-width="170"
            title="浏览器信息"
            show-overflow
            field="browserInfo"
          >
            <template slot-scope="{ row }">
              <span>{{ row.browserInfo | empty }}</span>
            </template>
          </vxe-table-column>
          <vxe-table-column
            min-width="70"
            :title="$t('AbpAuditLogging[\'Action\']')"
            fixed="right"
          >
            <template slot-scope="{ row }">
              <vxe-button
                type="text"
                status="primary"
                @click="handleDetail(row)"
                :content="$t('AbpAuditLogging.Detail')"
              ></vxe-button>
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
        >
        </vxe-pager>
      </template>
    </updowspanel>
    <audit-log-details ref="auditLogDetailsDialog" />
  </div>
</template>

<script>
import { getAuditLogs } from "@/api/auditlogging/auditlog";
import moment from "moment";
import { pickerRangeWithHotKey } from "@/utils/picker";
import AuditLogDetails from "./details";
import updowspanel from "@/components/MainView/updowspanel";
export default {
  name: "AuditLogs",
  components: { AuditLogDetails, updowspanel },
  filters: {
    requestDurationFilter(duration) {
      let type = "success";
      if (duration > 2 * 1000) {
        type = "warning";
      } else if (duration > 5 * 1000) {
        type = "error";
      }
      return type;
    },
    requestStatusCode(code) {
      let type = "success";
      switch (code) {
        case 401:
        case 403:
        case 404:
          type = "warning";
          break;
        case 500:
          type = "danger";
          break;
      }
      return type;
    },
    requestMethodFilter(method) {
      let type = "success";
      if (method != null) {
        switch (method.toUpperCase()) {
          case "GET":
            type = "";
            break;
          case "PUT":
            type = "warning";
            break;
          case "POST":
            type = "success";
            break;
          case "DELETE":
            type = "danger";
            break;
          default:
            type = "Info";
        }
      }

      return type;
    },
  },
  data() {
    return {
      tableheight: 200,
      datalist: [],
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },

      queryForm: {
        startTime: "",
        endTime: "",
        queryDateTime: "",
        httpMethod: "",
        url: "",
        userName: "",
        tenantName: "",
        applicationName: "",
        hasException: false,
        httpStatusCode: "",
      },
      pickerOptions: pickerRangeWithHotKey,
    };
  },
  methods: {
    moment,
    getList() {
      // if (this.queryForm.queryDateTime) {
      //   this.queryForm.startTime = this.queryForm.queryDateTime[0];
      //   this.queryForm.endTime = this.queryForm.queryDateTime[1];
      // }
      this.queryForm.startTime =
        this.queryForm.queryDateTime != null &&
        this.queryForm.queryDateTime.length != 0
          ? this.queryForm.queryDateTime[0]
          : null;
      this.queryForm.endTime =
        this.queryForm.queryDateTime != null &&
        this.queryForm.queryDateTime.length != 0
          ? this.queryForm.queryDateTime[1]
          : null;
      console.log(this.queryForm);

      const { currentPage, pageSize } = this.tablePage;
      let param = {
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      let allparam = Object.assign({}, this.queryForm, param);
      getAuditLogs(allparam).then((response) => {
        this.datalist = response.items;
        this.tablePage.totalResult = response.totalCount;
      });
    },
    resetQueryForm() {
      this.tablePage.currentPage = 1;
      this.tablePage.pageSize = 10;
      this.tablePage.totalResult = 10;
      this.queryForm = Object.assign(
        {
          queryDateTime: "",
          startTime: "",
          endTime: "",
          httpMethod: "",
          url: "",
          userName: "",
          tenantName: "",
          applicationName: "",
          hasException: false,
          httpStatusCode: "",
        },
        {}
      );
    },
    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.pageSize = pageSize;
      this.getList();
    },
    handleDetail(row) {
      this.$refs["auditLogDetailsDialog"].createLogInfo(row);
    },
    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height;
      });
    },
  },
  created() {
    this.getList();
  },
};
</script>

<style scoped lang="scss">
@import "@/styles/elform.scss";
</style>