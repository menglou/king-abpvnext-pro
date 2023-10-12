<template>
  <div :style="backstyle" class="login-form">
    <div class="container">
      <div class="login_title">
        <div class="left_title">
          <img src="../../assets/login/loginleft.png" height="40px">
        </div>
      </div>
      <div class="login-box">
        <div class="login-text">
          <p class="max-text">立信智能用水监管系统</p>
          <p class="min-text">
            系统通过无线网络，对远传小表、大表、流量计<br>等多种设备进行数据采集和控制，支持多种<br>
            设备协议，并可以灵活扩展。<br>
          </p>
        </div>
        <div class="login">
          <div class="login_logo">
            <a href="#">
              <img src="../../assets/login/fromlogin.png">
            </a>
          </div>
          <div class="login_name">
            <p>用水监管系统</p>
          </div>

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
              <el-form-item>
                <vxe-button
                  :loading="loading"
                  status="primary"
                  @click="login"
                >{{
                  loading == false
                    ? $t("AbpAccount['Login']")
                    : $t("AbpAccount['Login']")
                }}</vxe-button>
              </el-form-item>

              <!-- 租户切换和多语言切换 -->
              <el-form-item>
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
    </div>
    <div class="cb n5" />
    <div class="copyright">
      版权所有：江阴立信智能设备有限公司&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;
      电话：0510-86405123&nbsp;&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;&nbsp;Email：<a
        style="color: #6198fc"
        href="mailto:shg@lxzn.cn"
      >shg@lxzn.cn
      </a>
    </div>
    <el-dialog
      :title="$t('AbpUiMultiTenancy[\'SwitchTenant\']')"
      :visible.sync="tenantDialogFormVisible"
    >
      <el-form ref="dataForm" :model="tenant" label-position="top">
        <el-form-item :label="$t('AbpUiMultiTenancy[\'Name\']')">
          <el-input v-model="tenant.name" type="text" />
          <span>{{ $t("AbpUiMultiTenancy['SwitchTenantHint']") }}</span>
        </el-form-item>
      </el-form>
      <div slot="footer" class="dialog-footer">
        <el-button @click="tenantDialogFormVisible = false">
          {{ $t("AbpTenantManagement['Cancel']") }}
        </el-button>
        <el-button
          type="primary"
          :disabled="tenantDisabled"
          @click="saveTenant()"
        >
          {{ $t("AbpTenantManagement['Save']") }}
        </el-button>
      </div>
    </el-dialog>
  </div>
</template>

<script>
import LangSelect from '@/components/LangSelect'
export default {
  components: {
    LangSelect
  },
  data() {
    return {
      backstyle: {
        backgroundImage:
          'url(' + require('../../assets/login/bglogin.jpg') + ')',
        backgroundRepeat: 'no-repeat'
      },
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
            message: this.$t('login.vericodeplachoer'),
            trigger: 'blur'
          }
        ]
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
  },
  created() {},
  methods: {
    login() {
      this.$refs.loginruleForm.validate((valid) => {
        if (valid) {
          this.loading = true
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
    }
  }
}
</script>

<style scoped>
.login-form {
  height: 100%;
  min-height: 720px;
}
.container {
  height: 90%;
  min-height: 630px;
}
.login_title {
  /* border-bottom: 1px solid #ffffff40; */
}
.left_title {
  padding: 15px 35px;
}
.login-box {
  width: 1100px;
  margin: 120px auto 0;
}
.login-text {
  width: 500px;
  height: 440px;
  float: left;
  margin-left: 40px;
  margin-top: 100px;
}
.max-text {
  font-size: 35px;
  color: white;
  letter-spacing: 3px;
}
.min-text {
  font-size: 18px;
  color: white;
  letter-spacing: 3px;
  margin-top: 15px;
  line-height: 35px;
}
.login {
  min-height: 400px;
  width: 450px;
  padding: 50px;
  background-color: #ffffff;
  border-radius: 6px;
  box-sizing: border-box;
  float: right;
  margin-right: 100px;
  position: relative;
  margin-top: 45px;
  box-shadow: 2px 3px #d2d2d2;
}
.login_logo {
  width: 120px;
  height: 120px;
  border: 5px solid #93defe;
  border-radius: 100px;
  background: #fff;
  text-align: center;
  line-height: 110px;
  position: absolute;
  top: -60px;
  right: 35%;
}
.login_logo img {
  width: 80px;
  height: 80px;
  border-radius: 40px;
  display: inline-block;
  vertical-align: middle;
}
img {
  border: none;
}
.login_name {
  width: 100%;
  float: left;
  text-align: center;
  margin-top: 20px;
  margin-bottom: 10px;
}

.vxe-button {
  width: 100%;
  height: 46px;
  margin-top: 8px;
  font-size: 17px;
}
.cb {
  clear: both;
}
.copyright {
  font-size: 14px;
  color: grey;
  width: 100%;
  position: relative;
  top: 20px;
  text-align: center;
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
