<template>
  <div class="container">
    <div class="loginfrom">
      <div class="loginfrom-left hidden-xs-only hidden-sm-only">
        <img src="../../assets/image/LoginDefault.png" />
        <p class="contents">澄水物联基础开发框架</p>
        <p style="font-size: 14px">
          澄水物联的开发模式为 AbpVnext+Vue-Elemnet-Admin,
          基础开发框架采用分为两个版本采用不同的鉴权方式，匹配相应当前主流得前端开发模式，目前基础框架功能包含
          用户,角色,组织架构,权限,日志,系统配置,SingR等基础功能,开发者可以在此基础上完成实际业务的扩展
        </p>
      </div>

      <div class="loginfrom-right">
        <div class="loginfrom-right-title">
          <span style="font-weight: blod; font-size: 22px; colo: #40485b">
            登录
          </span>
          <span
            v-if="
              JSON.parse(
                app.abpConfig.setting.values[
                  'Abp.Account.IsSelfRegistrationEnabled'
                ]
              )
            "
            style="font-size: 14px; color: #40485b"
            >没有账号?
            <span style="cursor: pointer; font-size: 14px; color: #1283ba"
              >点此注册</span
            ></span
          >
        </div>
        <div class="loginfrom-right-form">
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
            <!-- 验证码 -->
            <el-form-item prop="vericode" style="margin-top: 15px">
              <div style="text-align: left; width: 100%">
                <el-input
                  v-model="loginform.vericode"
                  size="medium"
                  style="width: 100%"
                  :placeholder="$t('login.vericodeplachoer')"
                >
                  <template slot="append">
                    <el-image
                      ref="verImg"
                      :src="veriCodeUrl"
                      style="
                        width: 120px;
                        height: 40px;
                        vertical-align: middle;
                        cursor: pointer;
                      "
                      title="点击刷新"
                      @click="changeVeriCode"
                  /></template>
                </el-input>
              </div>
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
                      }}</i></el-link
                    >
                  </el-tooltip>
                </p>
                <div style="cursor: pointer; color: #1283ba; font-size: 13px">
                  短信验证登录
                </div>
              </div>
            </el-form-item>
            <el-form-item>
              <vxe-button :loading="loading" status="primary" @click="login">{{
                loading == false
                  ? $t("AbpAccount['Login']")
                  : $t("AbpAccount['Login']")
              }}</vxe-button>
            </el-form-item>
            <el-divider
              v-if="
                JSON.parse(
                  app.abpConfig.setting.values['Abp.Account.EnableLocalLogin']
                ) &&
                JSON.parse(
                  app.abpConfig.features.values['BasicManagementBackEnd.SocialLogins']
                )
              "
              >其他方式登录</el-divider
            >
            <div
              v-if="
                JSON.parse(
                  app.abpConfig.setting.values['Abp.Account.EnableLocalLogin']
                ) &&
                JSON.parse(
                  app.abpConfig.features.values['BasicManagementBackEnd.SocialLogins']
                )
              "
              class="otherlogin"
            >
              <div class="otherlogin-item">
                <el-tooltip
                  class="item"
                  effect="dark"
                  content="使用微信账号登录"
                  placement="bottom"
                >
                  <img src="../../assets/image/weixin.png" />
                </el-tooltip>
              </div>
              <div class="otherlogin-item">
                <el-tooltip
                  class="item"
                  effect="dark"
                  content="使用支付宝账号登录"
                  placement="bottom"
                >
                  <img src="../../assets/image/zhifubao.png" />
                </el-tooltip>
              </div>
              <div class="otherlogin-item">
                <el-tooltip
                  class="item"
                  effect="dark"
                  content="使用QQ账号登录"
                  placement="bottom"
                >
                  <img src="../../assets/image/qq.png" />
                </el-tooltip>
              </div>
              <div class="otherlogin-item">
                <el-tooltip
                  class="item"
                  effect="dark"
                  content="使用钉钉账号登录"
                  placement="bottom"
                >
                  <img src="../../assets/image/dingding.png" />
                </el-tooltip>
              </div>
              <div class="otherlogin-item">
                <el-tooltip
                  class="item"
                  effect="dark"
                  content="使用GitHub账号登录"
                  placement="bottom"
                >
                  <img src="../../assets/image/github.png" />
                </el-tooltip>
              </div>
            </div>
          </el-form>
        </div>
      </div>
      <div style="position: relative; right: 35px; top: -45%">
        <el-tooltip
          class="item"
          effect="dark"
          content="切换语言"
          placement="bottom"
        >
          <lang-select class="set-language" />
        </el-tooltip>
      </div>
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
import LangSelect from "@/components/LangSelect";
import { getveriCode, vertifyveriCode } from "@/api/verification/index";
import { isEmpty } from "@/utils/index";
export default {
  components: {
    LangSelect,
  },
  data() {
    return {
      app: this.$store.state.app,
      loading: false,
      loginform: {
        username: "",
        password: "",
        vericode: "",
        vericodeId: "",
      },
      veriCodeUrl: "",
      pwdinputtype: "password",
      loginrules: {
        userNameOrEmailAddress: [
          {
            required: true,
            message: this.$i18n.t("AbpAccount['ThisFieldIsRequired.']"),
            trigger: ["blur", "change"],
          },
        ],
        password: [
          {
            required: true,
            message: this.$i18n.t("AbpAccount['ThisFieldIsRequired.']"),
            trigger: ["blur", "change"],
          },
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
      tenant: { name: this.$store.getters.abpConfig.currentTenant.name },
    };
  },
  computed: {
    currentTenant() {
      return this.$store.getters.abpConfig.currentTenant.name;
    },
    features() {
      return this.$store.getters.abpConfig.features.values;
    },
    tenantDisabled() {
      if (
        this.tenant.name &&
        this.tenant.name === this.$store.getters.abpConfig.currentTenant.name
      ) {
        return true;
      }
      return false;
    },
  },
  watch: {
    $route: {
      handler: function (route) {
        const query = route.query;
        if (query) {
          this.redirect = query.redirect;
          this.otherQuery = this.getOtherQuery(query);
        }
      },
      immediate: true,
    },
  },
  mounted() {
    if (this.loginform.username === "") {
      this.$refs.username.focus();
    } else if (this.loginform.password === "") {
      this.$refs.password.focus();
    }
  },
  created() {
    this.loadVeriCode();
  },
  methods: {
    isEmpty,
    login() {
      // 先做验证码验证，验证码通过就可以登录
      this.$refs.loginruleForm.validate((valid) => {
        if (valid) {
          this.loading = true;
          this.$store
            .dispatch("user/login", this.loginform)
            .then((res) => {
              this.loading = false;
              this.$router.push(
                {
                  path: this.redirect || "/", // #/basicSetting/collectionManage
                },
                () => {}
              );
            })
            .catch((error) => {
              this.loading = false;
            });
        } else {
          return false;
        }
      });
    },
    saveTenant() {
      this.$store
        .dispatch("app/setTenant", this.tenant.name)
        .then((response) => {
          if (response && !response.success) {
            this.$notify({
              title: this.$i18n.t("AbpUi['Error']"),
              message: this.$i18n.t(
                "AbpUiMultiTenancy['GivenTenantIsNotAvailable']",
                [this.tenant.name]
              ),
              type: "error",
              duration: 2000,
            });
            return;
          }

          this.tenantDialogFormVisible = false;
        });
    },
    pwdmouserenter() {
      this.pwdinputtype = "text";
    },
    pwdmouserleave() {
      this.pwdinputtype = "password";
    },
    getOtherQuery(query) {
      return Object.keys(query).reduce((acc, cur) => {
        if (cur !== "redirect") {
          acc[cur] = query[cur];
        }
        return acc;
      }, {});
    },
    loadVeriCode() {
      getveriCode().then((res) => {
        this.veriCodeUrl = `data:image/png;base64,${res.base64Str}`;
        this.loginform.vericodeId = res.id;
      });
    },
    changeVeriCode() {
      this.loadVeriCode();
    },
  },
};
</script>

<style  lang="scss"  scoped >
.container {
  width: 100vw;
  height: 100vh;
  background-image: url("~@/assets/login/bglogin.jpg");
  /* 背景图垂直、水平均居中 */
  background-position: center center;
  /* 背景图不平铺 */
  background-repeat: no-repeat;
  /* 当内容高度大于图片高度时，背景图像的位置相对于viewport固定 */
  background-attachment: fixed;
  /* 让背景图基于容器大小伸缩 */
  background-size: cover;
  display: flex;
  justify-content: center;
  align-items: center;
}
.loginfrom {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: center;
  height: 550px;

  .loginfrom-left {
    width: 470px;
    height: 100%;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: flex-start;
    position: relative;
    background: linear-gradient(0deg, #3a485a 0%, #607089 100%);
    border-radius: 5px 0px 0px 5px;
    padding: 98px 46px 48px;
    color: #fff;
    img {
      width: 200px;
      height: 180px;
    }
    .contents {
      display: flex;
      font-size: 22px;
      font-weight: bold;
      margin-top: 35px;
    }
  }
  .loginfrom-left::before {
    background: url("~@/assets//image/loginleft.png") no-repeat 0 0;
  }

  .loginfrom-left::before {
    content: "";
    position: absolute;
    top: 0;
    left: 0;
    bottom: 0;
    right: 0;
  }

  .loginfrom-right {
    width: 470px;
    background: #fff;
    height: 100%;
    padding: 68px 46px 48px;
    border-radius: 0px 5px 5px 0px;
    display: flex;
    flex-direction: column;
    align-items: center;
    .loginfrom-right-title {
      width: 100%;
      display: flex;
      flex-direction: row;
      justify-content: space-between;
      margin-bottom: 24px;
      align-items: flex-end;
    }
    .loginfrom-right-form {
      width: 100%;
      .vxe-button {
        width: 100%;
        height: 45px;
        margin-top: 6px;
        font-size: 17px;
        margin-bottom: 6px;
      }
      ::v-deep .el-input-group__append {
        padding: 0px;
      }
      ::v-deep .el-form-item--small .el-form-item__content {
        line-height: 22px !important;
      }
      ::v-deep .el-input--medium .el-input__inner {
        height: 42px !important;
        line-height: 42px !important;
        font-size: 19px;
      }
      ::v-deep .el-input--medium .el-input__icon {
        line-height: 42px;
        font-size: 20px;
      }
      ::v-deep .el-input--prefix .el-input__inner {
        padding-left: 36px;
      }
      ::v-deep .iconfont {
        font-size: 18px;
        line-height: 42px;
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

      .otherlogin {
        display: flex;
        align-content: center;
        justify-content: space-around;
        margin-top: 30px;
        width: 100%;
        .otherlogin-item {
          cursor: pointer;
          img {
            height: 35px;
            width: 35px;
          }
        }
      }
    }
  }
}
</style>
