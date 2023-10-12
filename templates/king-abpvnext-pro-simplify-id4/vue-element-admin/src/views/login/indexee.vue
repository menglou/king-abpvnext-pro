<template>
  <div class="login-form">
    <div class="login">
      <h2 class="login_name"><strong>餐饮</strong> 后台管理系统</h2>
      <div class="form">
        <el-form ref="loginruleForm" :model="loginform" :rules="loginrules">
          <el-form-item prop="username">
            <el-input
              ref="username"
              v-model="loginform.username"
              size="medium "
              :placeholder="$t('AbpAccount[\'UserNameOrEmailAddress\']')"
              prefix-icon="iconfont icon-user"
            />
          </el-form-item>
          <el-form-item prop="password" style="margin-top: 30px">
            <el-input
              v-model="loginform.password"
              size="medium "
              :placeholder="$t('AbpAccount[\'Password\']')"
              :type="pwdinputtype"
              prefix-icon="iconfont icon-password"
            >
              <i
                slot="suffix"
                :class="
                  pwdinputtype === 'password'
                    ? 'iconfont icon-password-not-view'
                    : 'iconfont icon-password-visible'
                "
                @mouseenter="pwdmouserenter"
                @mouseleave="pwdmouserleave"
              />
            </el-input>
          </el-form-item>
          <el-form-item prop="vericode" style="margin-top: 15px">
            <div style="text-align: left">
              <el-input
                v-model="loginform.vericode"
                size="medium "
                style="width: 60%"
                :placeholder="$t('login.vericodeplachoer')"
              />

              <el-image
                ref="verImg"
                :src="veriCodeUrl"
                style="width: 40%;height:45px;vertical-align: middle; cursor: pointer"
                title="点击刷新"
                @click="changeVeriCode"
              />
            </div>
          </el-form-item>
          <el-form-item>
            <vxe-button :loading="loading" status="primary" @click="login">{{
              loading == false
                ? $t("AbpAccount['Login']")
                : $t("AbpAccount['Login']")
            }}</vxe-button>
          </el-form-item>
          <!-- 租户切换和多语言切换 -->
          <el-form-item style="display: none;">
            <div class="languageandtenant">
              <p class="explain">
                {{ $t("AbpUiMultiTenancy['Tenant']") }}
                <el-tooltip
                  :content="$t('AbpUiMultiTenancy[\'Switch\']')"
                  effect="dark"
                  placement="bottom"
                >
                  <el-link
                    :underline="false"
                    @click="tenantDialogFormVisible = true"
                  ><i>{{
                    currentTenant
                      ? currentTenant
                      : $t("AbpUiMultiTenancy['NotSelected']")
                  }}</i></el-link>
                </el-tooltip>
              </p>
              <lang-select class="set-language" />
            </div>
          </el-form-item>
        </el-form>
      </div>
    </div>
  </div>
</template>

<script>
import { getveriCode } from '@/api/user'
import LangSelect from '@/components/LangSelect'
export default {
  components: {
    LangSelect
  },
  data() {
    return {
      //   backstyle: {
      //     backgroundImage:
      //       "url(" + require("../../assets/login/bglogin.jpg") + ")",
      //     backgroundRepeat: "no-repeat",
      //   },
      loading: false,
      loginform: {
        username: '',
        password: '',
        vericode: '',
        vericodeId: ''
      },
      veriCodeUrl: '',
      pwdinputtype: 'password',
      loginrules: {
        userNameOrEmailAddress: [
          {
            required: true,
            message: this.$i18n.t("AbpAccount['ThisFieldIsRequired.']"),
            trigger: ['blur', 'change']
          }
        ],
        password: [
          {
            required: true,
            message: this.$i18n.t("AbpAccount['ThisFieldIsRequired.']"),
            trigger: ['blur', 'change']
          }
        ],
        vericode: [
          {
            required: true,
            message: this.$t("login.vericodeplachoer"),
            trigger: "blur",
          },
        ],
      },
      redirect: undefined,
      otherQuery: {},
      tenantDialogFormVisible: false,
      tenant: { name: this.$store.getters.abpConfig.currentTenant.name }
    }
  },
  computed: {
    currentTenant() {
      return this.$store.getters.abpConfig.currentTenant.name
    },
    features() {
      return this.$store.getters.abpConfig.features.values
    },
    tenantDisabled() {
      if (
        this.tenant.name &&
        this.tenant.name === this.$store.getters.abpConfig.currentTenant.name
      ) {
        return true
      }
      return false
    }
  },
  watch: {
    $route: {
      handler: function(route) {
        const query = route.query
        if (query) {
          this.redirect = query.redirect
          this.otherQuery = this.getOtherQuery(query)
        }
      },
      immediate: true
    }
  },
  mounted() {
    if (this.loginform.username === '') {
      this.$refs.username.focus()
    } else if (this.loginform.password === '') {
      this.$refs.password.focus()
    }
    this.loadVeriCode()
  },
  created() {},
  methods: {
    login() {
      this.$refs.loginruleForm.validate((valid) => {
        if (valid) {
          this.loading = true
          console.log('loginform', this.loginform)
          this.$store
            .dispatch('user/login', this.loginform)
            .then((res) => {
              this.loading = false
              this.$router.push(
                {
                  path: this.redirect || '/' // #/basicSetting/collectionManage
                },
                () => {}
              )
            })
            .catch((error) => {
              this.loading = false
            })
        } else {
          return false
        }
      })
    },
    saveTenant() {
      this.$store
        .dispatch('app/setTenant', this.tenant.name)
        .then((response) => {
          if (response && !response.success) {
            this.$notify({
              title: this.$i18n.t("AbpUi['Error']"),
              message: this.$i18n.t(
                "AbpUiMultiTenancy['GivenTenantIsNotAvailable']",
                [this.tenant.name]
              ),
              type: 'error',
              duration: 2000
            })
            return
          }

          this.tenantDialogFormVisible = false
        })
    },
    pwdmouserenter() {
      this.pwdinputtype = 'text'
    },
    pwdmouserleave() {
      this.pwdinputtype = 'password'
    },
    getOtherQuery(query) {
      return Object.keys(query).reduce((acc, cur) => {
        if (cur !== 'redirect') {
          acc[cur] = query[cur]
        }
        return acc
      }, {})
    },
    loadVeriCode() {
      getveriCode().then(res => {
        this.veriCodeUrl = `data:image/png;base64,${res.base64Str}`
        this.loginform.vericodeId = res.id
      })
    },
    changeVeriCode() {
      this.loadVeriCode()
    }
  }
}
</script>

<style lang="scss" scoped>
.login-form {
  height: 100%;
  width: 100%;
  background: url(../../assets/login/bglogin.jpg) no-repeat center center;
  background-size: 100% 100%;
  overflow: hidden;
  display: flex;
  align-items: center;
  justify-content: center;
}

.login {
  min-height: 400px;
  width: 450px;
  padding: 30px 40px 40px 40px;
  margin: 0 auto;
  background-color: #ffffff;
  border-radius: 6px;
  box-sizing: border-box;
  box-shadow: 2px 3px #d2d2d2;
}
.login_name {
  font-size: 28px;
  text-align: center;
}

.vxe-button {
  width: 100%;
  height: 46px;
  margin-top: 8px;
  font-size: 17px;
}

::v-deep .el-input--medium .el-input__inner {
  height: 46px !important;
  line-height: 46px !important;
  font-size: 19px;
}
::v-deep .el-input--medium .el-input__icon {
  line-height: 46px;
  font-size: 20px;
}
::v-deep .el-input--prefix .el-input__inner {
  padding-left: 36px;
}
::v-deep .iconfont {
  font-size: 18px;
  line-height: 46px;
  padding-right: 3px;
}

.languageandtenant {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
}
.set-language {
  color: #2d3a4b;
  font-size: 18px;
  cursor: pointer;
}
.explain {
  color: #2d3a4b;
  font-size: 14px;
  padding-right: 15px;
}
</style>
