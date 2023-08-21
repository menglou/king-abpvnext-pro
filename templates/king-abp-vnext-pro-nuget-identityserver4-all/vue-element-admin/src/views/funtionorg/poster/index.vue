<template>
  <div>
    <updowspanel @setTableHeight="setTableHeight">
      <template slot="up">
        <el-form :inline="true" :model="searchform" class="form-inline">
          <el-form-item>
            <el-input
              ref="refsearchform"
              v-model="searchform.code"
              style="width: 200px"
              placeholder="请输入岗位编码"
            />
          </el-form-item>
          <el-form-item>
            <el-input
              ref="refsearchform"
              v-model="searchform.name"
              style="width: 200px"
              placeholder="请输入岗位名称"
            />
          </el-form-item>
          <el-form-item>
            <el-select v-model="searchform.status" style="width:200px" placeholder="岗位状态">
              <el-option value="1" label="正常" />
              <el-option value="0" label="停用" />
              <el-option :value="null" label="全部" />
            </el-select>
          </el-form-item>
          <el-form-item>
            <el-button v-if="checkPermission('Institution.Poster')" type="primary" @click="getposterlist">查询</el-button>
          </el-form-item>
          <el-form-item>
            <el-button type="primary" @click="reset">重置</el-button>
          </el-form-item>
        </el-form>
      </template>
      <template slot="down">
        <vxe-toolbar ref="xToolbar2" custom>
          <template #buttons>
            <el-button
              v-if="checkPermission('Institution.Poster.Create')"
              type="primary"
              icon="el-icon-plus"
              @click="addposterdialogdisplay"
            >新增岗位</el-button>
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
          <vxe-table-column title="岗位编码" min-width="150" field="code" />
          <vxe-table-column title="岗位名称" min-width="150" field="name" />
          <vxe-table-column title="岗位顺序" min-width="120" field="sotr" />
          <vxe-table-column title="状态" min-width="150" field="status">
            <template v-slot="{ row }">
              <el-tag v-if="row.status == 0" type="danger">停用</el-tag>
              <el-tag v-else-if="row.status == 1">正常</el-tag>
            </template>
          </vxe-table-column>
          <vxe-table-column title="创建时间" min-width="150" field="startDate">
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
              <el-button style="color:#409eff" icon="el-icon-edit" v-if="checkPermission('Institution.Poster.Update')" type="text" @click="editposter(row)">编辑</el-button>
              <el-button style="color:#f56c6c" icon="el-icon-delete" v-if="checkPermission('Institution.Poster.Delete')" type="text" @click="deleteposter(row)">删除</el-button>
              <el-button style="color:#67c23a" icon="el-icon-link" v-if="checkPermission('Institution.Poster.BindUser')" type="text" @click="binduser(row)">绑定用户</el-button>
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
    <addposterdialog ref="refaddposterdialog" />
    <editposterdialog ref="refeditposterdialog" />
    <binduserdialog ref="refbinduserdialog" />
  </div>
</template>

<script>
import { getposterpagelist, deleteposter } from '@/api/poster/index'
import addposterdialog from './dialog/addposterdialog'
import editposterdialog from './dialog/editposterdialog'
import binduserdialog from './dialog/binduserdialog'
import updowspanel from '@/components/MainView/updowspanel'
import moment from 'moment'
import { checkPermission } from '@/utils/abp'
export default {
  name: 'Poster',
  components: {
    updowspanel,
    addposterdialog,
    editposterdialog,
    binduserdialog
  },
  data() {
    return {
      tableheight: 200,
      datalist: [],
      searchform: {
        code: '',
        name: '',
        status: null
      },

      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0
      }
    }
  },

  created() {
    this.getposterlist()
  },
  methods: {
    moment,
    checkPermission,
    getposterlist() {
      const { currentPage, pageSize } = this.tablePage
      const param = {
        code: this.searchform.code,
        name: this.searchform.name,
        status: this.searchform.status,
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize
      }
      getposterpagelist(param).then((res) => {
        this.datalist = res.items
        this.tablePage.totalResult = res.totalCount
      })
    },
    reset() {
      this.searchform.code = ''
      this.searchform.name = ''
      this.status = null
    },
    // 新增岗位
    addposterdialogdisplay() {
      this.$refs.refaddposterdialog.createposterdialog(this.getposterlist)
    },
    // 编辑岗位
    editposter(row) {
      this.$refs.refeditposterdialog.editposterdialog(
        this.getposterlist,
        row.id
      )
    },
    // 绑定用户
    binduser(row) {
      this.$refs.refbinduserdialog.binduserdialog(
        this.getposterlist,
        row
      )
    },
    // 删除岗位
    deleteposter(row) {
      this.$confirm('确定要删除【' + row.name + '】?', '提示', {
        confirmButtonText: '确定',
        cancelButtonText: '取消',
        type: 'warning'
      })
        .then(() => {
          deleteposter(row.id).then(() => {
            this.$notify({
              title: '提示',
              message: '岗位删除成功',
              type: 'success'
            })
            this.getposterlist()
          })
        })
        .catch(() => {})
    },

    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage
      this.tablePage.pageSize = pageSize
      this.getposterlist()
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
