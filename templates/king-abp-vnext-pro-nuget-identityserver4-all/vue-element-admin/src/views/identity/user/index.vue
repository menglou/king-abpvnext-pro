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
              placeholder="请输入用户名,邮箱，手机号，姓，名"
            />
          </el-form-item>
          <el-form-item>
            <el-button type="primary" @click="getuserlist">查询</el-button>
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
              @click="adduserdialogdisplay"
            >添加用户</el-button>
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
          <vxe-table-column title="用户名" min-width="100" field="userName" />
          <vxe-table-column title="名字" min-width="100" field="surname" />
          <vxe-table-column title="姓氏" min-width="100" field="name" />
          <vxe-table-column title="邮箱" min-width="120" field="email" />
          <vxe-table-column
            title="手机号"
            min-width="150"
            field="phoneNumber"
          />
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
                    class="dropdown-item"
                    icon="el-icon-delete"
                    @click.native="deleteuser(row.id)"
                  >删除
                  </el-dropdown-item>
                  <el-dropdown-item
                    v-if="checkPermission('AbpIdentity.Users.Update')"
                    class="dropdown-item"
                    icon="el-icon-edit"
                    @click.native="modifyuser(row)"
                  >修改</el-dropdown-item>
                  <el-dropdown-item
                    v-if="
                      checkPermission('AbpIdentity.Users.ManagePermissions')
                    "
                    class="dropdown-item"
                    icon="el-icon-collection"
                    @click.native="changepermission(row)"
                  >权限</el-dropdown-item>
                  <el-dropdown-item
                    v-if="checkPermission('AbpIdentity.Users.LoclUnLock')"
                    class="dropdown-item"
                    :icon="
                      row.lockoutEnd == null ? 'el-icon-close' : 'el-icon-check'
                    "
                    @click.native="updatelockend(row)"
                  >{{
                    row.lockoutEnd == null ? "锁住" : "解锁"
                  }}</el-dropdown-item>
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
    <adduserdialog ref="refadduserdialog" />
    <edituserdialog ref="refedituserdialog" />
    <setpermissiondialog ref="refsetpermissiondialog" />
  </div>
</template>

<script>
import updowspanel from '@/components/MainView/updowspanel'
import {
  adduserdialog,
  edituserdialog,
  setpermissiondialog
} from './dialog/index'
import {
  getuserlist,
  deleterolesbyid,
  updateuserlockinfo,
  getuserinfobyid,
  deleteuserinfo
} from '@/api/identity/user'
import { checkPermission } from '@/utils/abp'
import moment from 'moment'
export default {
  name: 'User',
  components: {
    updowspanel,
    adduserdialog,
    edituserdialog,
    setpermissiondialog
  },
  data() {
    return {
      tableheight: 200,
      datalist: [],
      searchform: {
        filter: ''
      },
      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0
      }
    }
  },
  created() {
    this.getuserlist()
  },
  methods: {
    moment,
    checkPermission,
    getuserlist() {
      const { currentPage, pageSize } = this.tablePage
      const param = {
        filter: this.searchform.filter,
        Sorting: '',
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize
      }
      getuserlist(param).then((res) => {
        this.datalist = [...res.items]
        this.tablePage.totalResult = res.totalCount
      })
    },
    // 添加
    adduserdialogdisplay() {
      this.$refs.refadduserdialog.createadduserdialog(this.getuserlist)
    },

    // 修改
    modifyuser(row) {
      const title = '修改用户:' + row.userName
      this.$refs.refedituserdialog.createedituserdialog(
        this.getuserlist,
        title,
        row.id
      )
    },

    // 权限
    changepermission(row) {
      this.$refs.refsetpermissiondialog.createsetpermissiondialog(null, row.id)
    },

    // 删除
    deleteuser(row) {
      this.$confirm('此操作将永久删除该用户, 是否继续?', '提示', {
        confirmButtonText: '确定',
        cancelButtonText: '取消',
        type: 'warning'
      })
        .then(() => {
          deleteuserinfo(row).then((res) => {
            this.$notify({
              title: '成功',
              message: '删除成功',
              type: 'success'
            })
            this.getuserlist()
          })
        })
        .catch(() => {})
    },

    // 解锁/锁住
    updatelockend(row) {
      updateuserlockinfo(row.id).then((res) => {
        this.$notify({
          title: '提示',
          message: row.lockoutEnd == null ? '锁住用户成功' : '解锁用户成功',
          type: 'success'
        })
        this.getuserlist()
      })
    },
    // 激活/失效
    updateactive(row) {
      updateuseractiveinfo({
        id: row.id,
        isActive: !row.isActive
      }).then((res) => {
        this.$notify({
          title: '提示',
          message: row.isActive ? '冻结用户成功' : '激活用户成功',
          type: 'success'
        })
        this.getuserlist()
      })
    },

    // 分页
    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage
      this.tablePage.pageSize = pageSize
      this.getuserlist()
    },

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
