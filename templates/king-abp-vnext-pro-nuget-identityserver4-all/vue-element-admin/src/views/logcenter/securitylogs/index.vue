<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <vxe-form :data="searchform"  title-align="right" title-width="100px">
          <vxe-form-item title="应用程序" span="6">
            <template #default="{ data }">
              <el-input
                v-model="data.applicationName"
                style="width: 320px"
                clearable
                placeholder="请输入应用程序"
              />
            </template>
          </vxe-form-item>
          <vxe-form-item title="标识" span="6">
            <template #default="{ data }">
              <el-input
                v-model="data.identity"
                style="width: 320px"
                clearable
                placeholder="请输入标识"
              />
            </template>
          </vxe-form-item>
          <vxe-form-item title="用户名" span="6">
            <template #default="{ data }">
              <el-input
                v-model="data.userName"
                style="width: 320px"
                clearable
                placeholder="请输入用户名"
              />
            </template>
          </vxe-form-item>
          <vxe-form-item title="操作" span="6">
            <template #default="{ data }">
              <el-input
                v-model="data.actionName"
                style="width: 320px"
                clearable
                placeholder="请输入操作"
              />
            </template>
          </vxe-form-item>
          <vxe-form-item title="Client" span="6" folding>
            <template #default="{ data }">
              <el-input
                v-model="data.clientId"
                style="width: 320px"
                clearable
                placeholder="请输入Client"
              />
            </template>
          </vxe-form-item>
          <vxe-form-item title="CorrelationId" span="6" folding>
            <template #default="{ data }">
              <el-input
                v-model="data.correlationId"
                style="width: 320px"
                clearable
                placeholder="请输入CorrelationId"
              />
            </template>
          </vxe-form-item>
          <vxe-form-item title="日期" span="6" folding>
            <template #default="{ data }">
              <el-date-picker
                v-model="data.daterange"
                type="daterange"
                range-separator="至"
                start-placeholder="开始日期"
                end-placeholder="结束日期"
                value-format="yyyy-MM-dd"
              >
              </el-date-picker>
            </template>
          </vxe-form-item>
          <vxe-form-item align="right" span="24" collapse-node>
            <el-button type="primary" @click="getlist">查询</el-button>
          </vxe-form-item>
        </vxe-form>
      </template>

      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom> </vxe-toolbar>
        <vxe-table
          id="securitylog"
          :data="datalist"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
        >
          <vxe-table-column type="seq" width="60" />
          <vxe-table-column title="日期" min-width="140">
            <template v-slot="{ row }">
              {{ moment(row.creationTime).format("YYYY-MM-DD HH:mm:ss") }}
            </template>
          </vxe-table-column>
          <vxe-table-column title="操作" min-width="100" field="action" />
          <vxe-table-column
            title="IP地址"
            min-width="100"
            field="clientIpAddress"
          />
          <vxe-table-column
            title="浏览器信息"
            min-width="100"
            show-overflow
            field="browserInfo"
          />
          <vxe-table-column
            title="应用程序"
            min-width="140"
            field="applicationName"
          />
          <vxe-table-column title="标识" min-width="120" field="identity" />
          <vxe-table-column title="用户名" min-width="100" field="userName" />
          <vxe-table-column title="CLIENT" min-width="100" field="clientId" />
          <vxe-table-column
            title="CORRELATIONID"
            min-width="100"
            show-overflow
            field="correlationId"
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
      </template>
    </updowspanel>
  </div>
</template>

<script>
import { getSecurityLogs } from "@/api/identity/securitylog";
import updowspanel from "@/components/MainView/updowspanel";
import moment from "moment";
import { mapGetters } from "vuex";
export default {
  name: "",
  computed: {
    ...mapGetters(["abpConfig"]),
  },
  components: {
    updowspanel,
  },
  data() {
    return {
      tableheight: 200,
      datalist: [],
      searchform: {
        startTime: "",
        endTime: "",
        daterange: [],
        applicationName: "",
        identity: "",
        actionName: "",
        userName: "",
        clientId: "",
        correlationId: "",
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
    getlist() {
      this.searchform.startTime =
        this.searchform.daterange != null &&
        this.searchform.daterange.length != 0
          ? this.searchform.daterange[0] + "T00:00:00"
          : null;
      this.searchform.endTime =
        this.searchform.daterange != null &&
        this.searchform.daterange.length != 0
          ? this.searchform.daterange[1] + "T23:59:59"
          : null;
      const { currentPage, pageSize } = this.tablePage;
      let param = {
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      let allparam = Object.assign({}, this.searchform, param);
      getSecurityLogs(allparam).then((res) => {
        this.datalist = res.items;
        this.tablePage.totalResult = res.totalCount;
      });
    },

    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.pageSize = pageSize;
      this.getlist();
    },

    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height;
      });
    },
  },
  created() {
    this.getlist();
  },
};
</script>

<style lang="scss" scoped>
@import "@/styles/elform.scss";
</style> 