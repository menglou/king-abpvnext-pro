<template>
  <vxe-modal
    v-model="roleadddialogFormVisible"
    title="添加角色"
    :position="{ top: 120 }"
    width="600"
    @close="addrolemodalclose"
  >
    <template v-slot>
      <el-form
        ref="addroleForm"
        class="addroleform"
        :model="addroleForm"
        :rules="addroleFormrules"
        label-width="100px"
      >
        <el-form-item :label="$t('AbpIdentity[\'RoleName\']')" prop="name">
          <el-input ref="rolename" v-model="addroleForm.name" />
        </el-form-item>
        <el-form-item>
          <el-checkbox
            v-model="addroleForm.isDefault"
            :label="$t('AbpIdentity[\'DisplayName:IsDefault\']')"
          />
        </el-form-item>
        <el-form-item>
          <el-checkbox
            v-model="addroleForm.isPublic"
            :label="$t('AbpIdentity[\'DisplayName:IsPublic\']')"
          />
        </el-form-item>
      </el-form>

      <div class="modal-footer">
        <el-button type="primary" @click="saveuser">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { addroleinfo } from '@/api/identity/roles'
export default {
  name: 'Addroledialog',
  data() {
    return {
      callbackmethod: null,
      // 控制添加角色弹窗显示
      roleadddialogFormVisible: false,
      addroleForm: {
        name: '',
        isDefault: false,
        isPublic: false
      },
      addroleFormrules: {
        name: [{ required: true, message: '请输入角色名称', trigger: 'blur' }]
      }
    }
  },
  methods: {
    async createaddroledialog(cb) {
      this.callbackmethod = cb
      this.roleadddialogFormVisible = true
    },
    addrolemodalclose() {
      this.roleadddialogFormVisible = false
      this.$refs.addroleForm.resetFields()
      this.addroleForm.isDefault = false
      this.addroleForm.isDefault = false
    },
    saveuser() {
      this.$refs.addroleForm.validate((valid) => {
        if (valid) {
          addroleinfo(this.addroleForm).then((res) => {
            this.$notify({
              title: '提示',
              message: '添加角色成功',
              type: 'success'
            })
            this.callbackmethod()
            this.addrolemodalclose()
          })
        } else {
          this.roleadddialogFormVisible = true
          return false
        }
      })
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
