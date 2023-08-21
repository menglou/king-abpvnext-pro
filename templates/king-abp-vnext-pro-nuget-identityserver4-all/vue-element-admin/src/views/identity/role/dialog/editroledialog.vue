<template>
  <vxe-modal
    v-model="roleeditdialogFormVisible"
    :title="edittitle"
    :position="{ top: 120 }"
    width="600"
    @close="editrolemodalclose"
  >
    <template v-slot>
      <el-form
        ref="editroleForm"
        class="addroleform"
        :model="editroleForm"
        :rules="editroleFormrules"
        label-width="100px"
      >
        <el-form-item :label="$t('AbpIdentity[\'RoleName\']')" prop="name">
          <el-input ref="rolename" v-model="editroleForm.name" />
        </el-form-item>
        <el-form-item>
          <el-checkbox
            v-model="editroleForm.isDefault"
            :label="$t('AbpIdentity[\'DisplayName:IsDefault\']')"
          />
        </el-form-item>
        <el-form-item>
          <el-checkbox
            v-model="editroleForm.isPublic"
            :label="$t('AbpIdentity[\'DisplayName:IsPublic\']')"
          />
        </el-form-item>
      </el-form>

      <div class="modal-footer">
        <el-button type="primary" @click="edituser">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { updateroleinfo, getroleinfo } from '@/api/identity/roles'
export default {
  name: 'Editroledialog',
  data() {
    return {
      callbackmethod: null,
      // 控制修改角色弹窗显示
      roleeditdialogFormVisible: false,
      editroleForm: {
        id: '',
        name: '',
        isDefault: false,
        isPublic: false,
        concurrencyStamp: ''
      },
      editroleFormrules: {
        name: [{ required: true, message: '请输入角色名称', trigger: 'blur' }]
      },
      edittitle: ''
    }
  },
  methods: {
    async createeditroledialog(cb, title, id) {
      this.callbackmethod = cb
      this.edittitle = title
      this.roleeditdialogFormVisible = true
      await this.getroleinfo(id)
    },
    editrolemodalclose() {
      this.roleeditdialogFormVisible = false
      this.$refs.editroleForm.resetFields()
      this.editroleForm.concurrencyStamp = ''
      this.editroleForm.id = ''
      this.callbackmethod = null
      this.edittitle = ''
    },
    edituser() {
      this.$refs.editroleForm.validate((valid) => {
        if (valid) {
          updateroleinfo(this.editroleForm.id, this.editroleForm).then(
            (res) => {
              this.$notify({
                title: '提示',
                message: '修改角色成功',
                type: 'success'
              })
              this.callbackmethod()
              this.editrolemodalclose()
            }
          )
        } else {
          this.roleeditdialogFormVisible = true
          return false
        }
      })
    },
    async getroleinfo(id) {
      const res = await getroleinfo(id)
      this.editroleForm.id = res.id
      this.editroleForm.name = res.name
      this.editroleForm.isDefault = res.isDefault
      this.editroleForm.concurrencyStamp = res.concurrencyStamp
    }
  }
}
</script>

<style scoped>
.addroleform {
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
