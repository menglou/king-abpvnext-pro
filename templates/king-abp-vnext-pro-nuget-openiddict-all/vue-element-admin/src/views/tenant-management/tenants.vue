<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <div class="filter-container">
          <el-input
            v-model="filter"
            :placeholder="$t('AbpUi[\'PagerSearch\']')"
            style="width: 400px"
            class="filter-item"
            @keyup.enter.native="handleFilter"
          />
          <el-button
            v-if="checkPermission('AbpTenantManagement.Tenants.Create')"
            class="filter-item"
            style="margin-left: 10px"
            type="primary"
            icon="el-icon-edit"
            @click="handleCreate"
          >
            {{ $t("AbpTenantManagement['NewTenant']") }}
          </el-button>
        </div>
      </template>
      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom />
        <vxe-table
          id="tenant"
          :data="list"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
          :max-height="tableheight"
        >
          <vxe-table-column type="seq" width="60" />
          <vxe-table-column
            :title="$t('AbpTenantManagement[\'TenantName\']')"
            field="name"
            sortable
            min-width="140"
            align="center"
          >
            <template slot-scope="{ row }">
              <span>{{ row.name }}</span>
            </template>
          </vxe-table-column>
          <vxe-table-column
            :title="$t('AbpTenantManagement[\'Actions\']')"
            field="center"
            min-width="500"
            class-name="small-padding fixed-width"
          >
            <template v-slot="{ row }">
              <el-button
                v-if="checkPermission('AbpTenantManagement.Tenants.Update')"
                type="primary"
                size="mini"
                @click="handleUpdate(row)"
              >
                {{ $t("AbpTenantManagement['Edit']") }}
              </el-button>
              <el-button
                v-if="
                  checkPermission(
                    'AbpTenantManagement.Tenants.ManageConnectionStrings'
                  )
                "
                type="primary"
                size="mini"
                @click="handleUpdateConnectionString(row)"
              >
                {{
                  $t(
                    "AbpTenantManagement['Permission:ManageConnectionStrings']"
                  )
                }}
              </el-button>
              <el-button
                v-if="
                  checkPermission('AbpTenantManagement.Tenants.ManageFeatures')
                "
                type="primary"
                size="mini"
                @click="handleUpdateFeature(row)"
              >
                {{ $t("AbpTenantManagement['Permission:ManageFeatures']") }}
              </el-button>
              <el-button
                v-if="checkPermission('AbpTenantManagement.Tenants.Delete')"
                size="mini"
                type="danger"
                @click="handleDelete(row, $index)"
              >
                {{ $t("AbpTenantManagement['Delete']") }}
              </el-button>
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
    <tenant-dialog ref="tenantDialog" @handleFilter="handleFilter" />
    <connectionstring-dialog ref="connectionstringDialog" />
    <feature-dialog ref="featureDialog" provider-name="T" />
  </div>
</template>

<script>
import { getTenants, deleteTenant } from '@/api/multi-tenancy/tenant'
import Pagination from '@/components/Pagination' // secondary package based on el-pagination
import baseListQuery, { checkPermission } from '@/utils/abp'
import TenantDialog from './components/tenant-dialog'
import ConnectionstringDialog from './components/connectionstring-dialog'
import FeatureDialog from './components/feature-dialog'
import updowspanel from '@/components/MainView/updowspanel'
export default {
  name: 'Tenants',
  components: {
    updowspanel,
    Pagination,
    TenantDialog,
    ConnectionstringDialog,
    FeatureDialog
  },
  data() {
    return {
      tableheight: 200,
      list: [],
      filter: '',
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0
      }
    }
  },
  created() {
    this.getList()
  },
  methods: {
    checkPermission,
    getList() {
      const { currentPage, pageSize } = this.tablePage
      const data = {
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
        Filter: this.filter
      }
      getTenants(data).then((res) => {
        this.list = res.items
        this.tablePage.totalResult = res.totalCount
      })
    },
    handleFilter(firstPage = true) {
      if (firstPage) this.tablePage.currentPage = 1
      this.getList()
    },

    handleCreate() {
      this.$refs['tenantDialog'].handleCreate()
    },
    handleUpdate(row) {
      this.$refs['tenantDialog'].handleUpdate(row)
    },
    handleDelete(row, index) {
      this.$confirm(
        this.$i18n.t(
          "AbpTenantManagement['TenantDeletionConfirmationMessage']",
          [row.name]
        ),
        this.$i18n.t("AbpTenantManagement['AreYouSure']"),
        {
          confirmButtonText: this.$i18n.t("AbpTenantManagement['Yes']"),
          cancelButtonText: this.$i18n.t("AbpTenantManagement['Cancel']"),
          type: 'warning'
        }
      ).then(async() => {
        deleteTenant(row.id).then(() => {
          this.handleFilter()
          this.$notify({
            title: this.$i18n.t("Openiddict['Success']"),
            message: this.$i18n.t("Openiddict['SuccessMessage']"),
            type: 'success',
            duration: 2000
          })
        })
      })
    },
    handleUpdateConnectionString(row) {
      this.$refs['connectionstringDialog'].handleUpdate(row)
    },
    handleUpdateFeature(row) {
      this.$refs['featureDialog'].handleUpdate(row)
    },

    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage
      this.tablePage.pageSize = pageSize
      this.getList()
    },
    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height
      })
    }
  }
}
</script>
