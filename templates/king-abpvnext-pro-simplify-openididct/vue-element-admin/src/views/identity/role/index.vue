<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <el-form :inline="true" class="form-inline">
          <el-form-item label="角色名称">
            <el-input
              ref="reffilter"
              v-model="searchfilter"
              placeholder="请输入角色名称"
              style="width: 300px"
            />
          </el-form-item>
          <el-form-item>
            <el-button
              type="primary"
              icon="el-icon-search"
              @click="getRolesList"
            >查询</el-button>
          </el-form-item>
        </el-form>
      </template>
      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom>
          <template #buttons>
            <el-button
              v-if="checkPermission('AbpIdentity.Roles.Create')"
              type="primary"
              icon="el-icon-plus"
              @click="addroledialogdisplay"
            >添加角色</el-button>
          </template>
        </vxe-toolbar>
        <vxe-table
          id="user"
          :data="datalist"
          auto-resize
          align="center"
          :custom-config="{ storage: true }"
          border="inner"
        >
          <vxe-table-column type="seq" width="60" />
          <vxe-table-column
            title="角色名称"
            min-width="100"
            field="name"
          />
          <vxe-table-column title="操作" min-width="80">
            <template v-slot="{ row }">
              <el-button
                v-if="checkPermission('AbpIdentity.Roles.Update')"
                type="text"
                @click="modifyrole(row)"
              >修改</el-button>
              <el-button
                v-if="checkPermission('AbpIdentity.Roles.ManagePermissions')"
                type="text"
                @click="changepermission(row)"
              >权限</el-button>
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
    <addroledialog ref="refaddroledialog" />
    <editroledialog ref="refeditroledialog" />
    <setpermissiondialog ref="refsetpermissiondialog" />
  </div>
</template>

<script>
import {
  getRolesList,
  addroleinfo,
  updateroleinfo,
  getroleinfo
} from '@/api/identity/roles'
import {
  getPermissions,
  updatePermissions
} from '@/api/permission-management/permission'
import { fetchAppConfig } from '@/utils/abp'
import { checkPermission } from '@/utils/abp'
import updowspanel from '@/components/MainView/updowspanel'
import {
  addroledialog,
  editroledialog,
  setpermissiondialog
} from './dialog/index'
export default {
  name: 'Roles',
  components: {
    updowspanel,
    addroledialog,
    editroledialog,
    setpermissiondialog
  },
  data() {
    return {
      tableheight: 200,
      datalist: [],
      searchfilter: '',
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0
      }
    }
  },
  created() {
    this.getRolesList()
  },
  methods: {
    checkPermission,
    getRolesList() {
      const { currentPage, pageSize } = this.tablePage
      const param = {
        filter: this.searchfilter,
        Sorting: '',
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize
      }
      getRolesList(param).then((res) => {
        this.datalist = res.items
      })
    },
    // 添加
    addroledialogdisplay() {
      this.$refs.refaddroledialog.createaddroledialog(this.getRolesList)
    },

    // 修改
    modifyrole(row) {
      const title = '修改：' + row.name
      this.$refs.refeditroledialog.createeditroledialog(
        this.getRolesList,
        title,
        row.id
      )
    },
    // 权限
    changepermission(row) {
      const title = '权限-' + row.name
      this.$refs.refsetpermissiondialog.createsetpermissiondialog(
        title,
        row.name
      )
    },
    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage
      this.tablePage.pageSize = pageSize
      this.getRolesList()
    },
    // 权限
    setTableHeight(height) {
      this.$nextTick(() => {
        this.tableheight = height
      })
    }
  }
}
</script>

<style>
</style>
