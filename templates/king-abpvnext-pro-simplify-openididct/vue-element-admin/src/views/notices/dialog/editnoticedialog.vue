<template>
  <vxe-modal
    v-model="notcieeditdialogFormVisible"
    type="modal "
    title="修改公告"
    :position="{ top: 40 }"
    width="650"
    @close="editnoticemodalclose"
  >
    <template v-slot>
      <div style="margin: 5px 30px 5px 5px">
        <el-form ref="form" :model="form" :rules="rules" label-width="150px">
          <el-row>
            <el-col :span="24">
              <el-form-item label="公告标题" prop="title">
                <el-input v-model="form.title" placeholder="请输入公告标题" />
              </el-form-item>
            </el-col>
            <el-col :span="24">
              <el-form-item label="状态">
                <el-radio-group v-model="form.status">
                  <el-radio
                    v-for="dict in statusOptions"
                    :key="dict.value"
                    :label="dict.label"
                  >{{ dict.label }}</el-radio>
                </el-radio-group>
              </el-form-item>
            </el-col>
            <el-col :span="24">
              <el-form-item label="内容">
                <editor
                  v-model="form.content"
                  :min-height="192"
                  :height="260"
                />
              </el-form-item>
            </el-col>
          </el-row>
        </el-form>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="editnotice">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>
<script>
import Editor from '@/components/Editor'
import { updateBroadCastnotice } from '@/api/notcie'
export default {
  components: {
    Editor
  },
  data() {
    return {
      callbackmethod: null,
      notcieeditdialogFormVisible: false,
      form: {
        id: '',
        title: '',
        status: '',
        content: '',
        isCreate: false
      },
      statusOptions: [
        { label: '正常', value: 0 },
        { label: '关闭', value: 1 }
      ],
      rules: {
        title: [
          { required: true, message: '公告标题不能为空', trigger: 'blur' }
        ]
      }
    }
  },
  methods: {
    createeditnoticedialog(cb, row) {
      this.callbackmethod = cb
      this.notcieeditdialogFormVisible = true
      this.form.id = row.id
      this.form.title = row.title
      this.form.status = row.status == 0 ? '正常' : '关闭'
      this.form.content = row.content
    },
    editnoticemodalclose() {
      this.callbackmethod = null
      this.$refs.form.resetFields()
      this.form.id = ''
      this.form.status = '正常'
      this.form.isCreate = false
      this.form.content = ''
      this.notcieeditdialogFormVisible = false
    },

    editnotice() {
      const param = this.form
      param.status = this.form.status == '正常' ? 0 : 1
      this.$refs.form.validate((valid) => {
        if (valid) {
          updateBroadCastnotice(param.id, param).then((res) => {
            this.$notify({
              title: '提示',
              message: '修改通告成功',
              type: 'success'
            })
            this.callbackmethod()
            this.editnoticemodalclose()
          })
        } else {
          console.log('error submit!!')
          return false
        }
      })
    }
  }
}
</script>

<style scoped>
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
