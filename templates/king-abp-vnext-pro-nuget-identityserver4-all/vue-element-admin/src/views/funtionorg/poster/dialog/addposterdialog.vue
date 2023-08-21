<template>
  <vxe-modal
    v-model="posteradddialogFormVisible"
    type="modal "
    title="添加岗位"
    :position="{ top: 40 }"
    width="550"
    @close="addpostermodalclose"
  >
    <template v-slot>
      <div class="modal-top">
        <el-form
          ref="addForm"
          :model="addForm"
          :rules="addFormrules"
          label-width="250px"
        >
          <el-form-item label="岗位名称" label-width="100px" prop="name">
            <el-input v-model="addForm.name" type="name" />
          </el-form-item>
          <el-form-item label="岗位编码" label-width="100px" prop="code">
            <el-input v-model="addForm.code" type="name" />
          </el-form-item>
          <el-form-item label="岗位顺序" label-width="100px" prop="sotr">
            <el-input-number
              v-model="addForm.sotr"
              controls-position="right"
              :min="0"
            />
          </el-form-item>
          <el-form-item label="岗位状态" label-width="100px" prop="status">
            <el-radio-group v-model="addForm.status">
              <el-radio :label="1">正常</el-radio>
              <el-radio :label="0">停用</el-radio>
            </el-radio-group>
          </el-form-item>
        </el-form>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="confirmaddForm">确 定</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { addposter } from '@/api/poster/index'
import moment from 'moment'
export default {
  data() {
    return {
      callbackmethod: null,
      posteradddialogFormVisible: false,
      addForm: {
        name: '',
        code: '',
        sotr: '',
        status: 1
      },
      addFormrules: {
        name: [
          { required: true, message: '请输入岗位名称', trigger: 'blur' }
        ],
        code: [
          { required: true, message: '请输入岗位编码', trigger: 'blur' }
        ],
        sotr: [
          { required: true, message: '请输入岗位顺序', trigger: 'blur' }
        ]
      }
    }
  },
  methods: {
    moment,
    createposterdialog(cb) {
      this.callbackmethod = cb
      this.posteradddialogFormVisible = true
    },
    confirmaddForm() {
      this.$refs.addForm.validate((valid) => {
        if (valid) {
          const param = {
            name: this.addForm.name,
            code: this.addForm.code,
            sotr: this.addForm.sotr.toString(),
            status: this.addForm.status
          }
          addposter(param).then((res) => {
            if (res === true) {
              this.posteradddialogFormVisible = false
              this.$notify({
                title: '提示',
                message: '添加岗位成功',
                type: 'success'
              })
              this.callbackmethod()
              this.addpostermodalclose()
            }
          })
        } else {
          return false
        }
      })
    },
    addpostermodalclose() {
      this.callbackmethod = null
      this.$refs.addForm.resetFields()
      this.posteradddialogFormVisible = false
    }
  }
}
</script>

<style scoped>
.modal-top {
  margin: 25px 35px 15px 30px;
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
.tabs {
  margin: 0.8em 1em;
}

::v-deep .el-tabs__nav-wrap::after {
  height: 1.5px;
}
::v-deep .vxe-modal--footer {
  border-top: 1px solid #eee;
}
::v-deep .vxe-modal--wrapper .vxe-modal--footer {
  padding: 5px 10px;
}
</style>
