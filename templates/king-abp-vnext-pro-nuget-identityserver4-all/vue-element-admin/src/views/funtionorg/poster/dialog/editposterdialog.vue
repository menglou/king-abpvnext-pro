<template>
  <vxe-modal
    v-model="postereditdialogFormVisible"
    type="modal "
    title="编辑岗位"
    :position="{ top: 40 }"
    width="550"
    @close="editpostermodalclose"
  >
    <template v-slot>
      <div class="modal-top">
        <el-form
          ref="editForm"
          :model="editForm"
          :rules="addFormrules"
          label-width="250px"
        >
          <el-form-item label="岗位名称" label-width="100px" prop="name">
            <el-input v-model="editForm.name" type="name" />
          </el-form-item>
          <el-form-item label="岗位编码" label-width="100px" prop="code">
            <el-input v-model="editForm.code" type="name" />
          </el-form-item>
          <el-form-item label="岗位顺序" label-width="100px" prop="sotr">
            <el-input-number
              v-model="editForm.sotr"
              controls-position="right"
              :min="0"
            />
          </el-form-item>
          <el-form-item label="岗位状态" label-width="100px" prop="status">
            <el-radio-group v-model="editForm.status">
              <el-radio :label="1">正常</el-radio>
              <el-radio :label="0">停用</el-radio>
            </el-radio-group>
          </el-form-item>
        </el-form>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="editposter">确 定</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { getposterinfo, editposter } from '@/api/poster/index'
import moment from 'moment'
export default {
  data() {
    return {
      callbackmethod: null,
      postereditdialogFormVisible: false,
      editForm: {
        id: '',
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
    async editposterdialog(cb, id) {
      this.callbackmethod = cb
      this.postereditdialogFormVisible = true
      this.editForm = await getposterinfo(id)
    },
    editposter() {
      this.$refs.editForm.validate((valid) => {
        if (valid) {
          const param = {
            id: this.editForm.id,
            name: this.editForm.name,
            code: this.editForm.code,
            sotr: this.editForm.sotr.toString(),
            status: this.editForm.status

          }
          editposter(param).then((res) => {
            if (res === true) {
              this.postereditdialogFormVisible = false
              this.$notify({
                title: '提示',
                message: '更新岗位成功',
                type: 'success'
              })
              this.callbackmethod()
              this.editpostermodalclose()
            }
          })
        } else {
          return false
        }
      })
    },
    editpostermodalclose() {
      this.callbackmethod = null
      this.$refs.editForm.resetFields()
      this.postereditdialogFormVisible = false
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
