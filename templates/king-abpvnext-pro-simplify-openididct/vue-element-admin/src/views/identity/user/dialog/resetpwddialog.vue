<template>
  <vxe-modal
    v-model="resetpwddialogFormVisible"
    type="modal "
    title="重置密码"
    :position="{ top: 200 }"
    width="400"
    @close="resetpwdmodalclose"
  >
    <template v-slot>
      <div style="margin: 20px 30px 5px 5px">
        <el-form
          ref="resetpwdForm"
          :model="resetpwdForm"
          :rules="resetpwdFormrules"
          label-width="100px"
        >
          <el-form-item
            :label="$t('AbpIdentity[\'DisplayName:NewPassword\']')"
            prop="newpassword"
          >
            <el-input v-model="resetpwdForm.newpassword" type="password" />
          </el-form-item>
          <el-form-item
            :label="$t('AbpIdentity[\'DisplayName:NewPasswordConfirm\']')"
            prop="confirmpassword"
          >
            <el-input v-model="resetpwdForm.confirmpassword" type="password" />
          </el-form-item>
        </el-form>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="savepwd">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { resetpassword } from '@/api/identity/user'
export default {
  data() {
    const passwordValidator = (rule, value, callback) => {
      if (!value) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['Password']")
            ])
          )
        )
        return
      }
      if (value.length < this.requiredLength) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['Volo.Abp.Identity:PasswordTooShort']", [
              `${this.requiredLength}`
            ])
          )
        )
        return
      }
      if (value.length > 128) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['The field {0} must be a string with a maximum length of {1}.']",
              [this.$i18n.t("AbpIdentity['Password']"), '128']
            )
          )
        )
        return
      }
      let reg = /\d+/
      if (this.requireDigit && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresDigit']"
            )
          )
        )
        return
      }
      reg = /[a-z]+/
      if (this.requireLowercase && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresLower']"
            )
          )
        )
        return
      }
      reg = /[A-Z]+/
      if (this.requireUppercase && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresUpper']"
            )
          )
        )
        return
      }
      reg = /\W+/
      if (this.requireNonAlphanumeric && !reg.test(value)) {
        callback(
          new Error(
            this.$i18n.t(
              "AbpIdentity['Volo.Abp.Identity:PasswordRequiresNonAlphanumeric']"
            )
          )
        )
        return
      }

      callback()
    }
    var avalidatePass = (rule, value, callback) => {
      if (value === '') {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['The {0} field is required.']", [
              this.$i18n.t("AbpIdentity['DisplayName:NewPasswordConfirm']")
            ])
          )
        )
      } else if (value !== this.resetpwdForm.newpassword) {
        callback(
          new Error(
            this.$i18n.t("AbpIdentity['ThisFieldIsNotValid.']", [
              this.$i18n.t("AbpIdentity['DisplayName:NewPassword']"),
              this.$i18n.t("AbpIdentity['DisplayName:NewPasswordConfirm']")
            ])
          )
        )
      } else {
        callback()
      }
    }
    return {
      callbackmethod: null,
      resetpwddialogFormVisible: false,
      userId: '',
      resetpwdForm: {
        newpassword: '',
        confirmpassword: ''
      },
      resetpwdFormrules: {
        newpassword: [
          {
            required: true,
            validator: passwordValidator,
            trigger: ['blur', 'change']
          }
        ],
        confirmpassword: [
          {
            required: true,
            validator: avalidatePass,
            trigger: ['blur', 'change']
          }
        ]
      }
    }
  },
  computed: {
    requiredLength() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequiredLength'
        ] || 6
      )
    },
    requiredUniqueChars() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequiredUniqueChars'
        ] || 1
      )
    },
    requireLowercase() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireLowercase'
        ] || true
      )
    },
    requireNonAlphanumeric() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireNonAlphanumeric'
        ] || true
      )
    },
    requireUppercase() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireUppercase'
        ] || true
      )
    },
    requireDigit() {
      return (
        this.$store.state.app.abpConfig.setting.values[
          'Abp.Identity.Password.RequireDigit'
        ] || true
      )
    }
  },
  methods: {
    async createresetpwddialog(cb, userid) {
      this.callbackmethod = cb
      this.resetpwddialogFormVisible = true
      this.userId = userid
    },
    savepwd() {
      this.$refs.resetpwdForm.validate((valid) => {
        if (valid) {
          resetpassword({
            userId: this.userId,
            password: this.resetpwdForm.newpassword
          }).then((res) => {
            this.$notify({
              title: '提示',
              message: '重置密码成功！',
              type: 'success'
            })
            this.callbackmethod()
            this.resetpwdmodalclose()
          })
        }
      })
    },
    resetpwdmodalclose() {
      this.callbackmethod = null
      this.$refs.resetpwdForm.resetFields()
      this.resetpwdForm.newpassword = ''
      this.resetpwdForm.confirmpassword = ''
      this.resetpwddialogFormVisible = false
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
