<template>
  <vxe-modal
    v-model="scheduletaskeditdialogFormVisible"
    type="modal "
    title="编辑任务"
    :position="{ top: 40 }"
    width="750"
    @close="editscheduletaskmodalclose"
  >
    <template v-slot>
      <el-form
        ref="form"
        :model="scheduletaskform"
        :rules="rules"
        label-width="110px"
      >
        <el-tabs v-model="activeName" class="tabs">
          <el-tab-pane label="基础信息配置" name="first">
            <el-form-item label="任务类型">
              <el-radio-group v-model="scheduletaskform.jobTypeName">
                <el-radio label="Http任务"></el-radio>
                <el-radio disabled label="程序集任务"></el-radio>
              </el-radio-group>
            </el-form-item>
            <el-form-item label="任务名称" prop="title">
              <el-input v-model="scheduletaskform.title"></el-input>
            </el-form-item>
            <el-form-item label="任务分组" prop="jobGroup">
              <el-input v-model="scheduletaskform.jobGroup"></el-input>
            </el-form-item>
            <el-form-item label="按周期运行">
              <el-switch
                style="width: 100%"
                v-model="scheduletaskform.runLoop"
              ></el-switch>
              <span>如果关闭按钮表示只在任务开始时执行一次 </span>
            </el-form-item>
            <el-form-item
              prop="cronExpression"
              label="Cron表达式"
              v-show="scheduletaskform.runLoop == true"
            >
              <el-input v-model="scheduletaskform.cronExpression"></el-input>
            </el-form-item>
            <el-form-item label="开始时间">
              <el-date-picker
                v-model="scheduletaskform.startDate"
                type="datetime"
                style="width: 100%"
                placeholder="选择任务开始日期时间"
                format="yyyy-MM-dd HH:mm:ss"
                value-format="yyyy-MM-dd HH:mm:ss"
              >
              </el-date-picker>
            </el-form-item>
            <el-form-item label="结束时间">
              <el-date-picker
                v-model="scheduletaskform.endDate"
                type="datetime"
                style="width: 100%"
                placeholder="选择任务结束日期时间"
                format="yyyy-MM-dd HH:mm:ss"
                value-format="yyyy-MM-dd HH:mm:ss"
              >
              </el-date-picker>
              <span>为空表示不限制任务的停止时间 </span>
            </el-form-item>
            <el-form-item label="备注" prop="remark">
              <el-input
                type="textarea"
                v-model="scheduletaskform.remark"
              ></el-input>
            </el-form-item>
          </el-tab-pane>
          <el-tab-pane label="元数据配置" name="second">
            <!-- <el-form :model="scheduletaskform" label-width="110px"> -->
            <el-form-item prop="requestUrl" label="请求地址">
              <el-input v-model="scheduletaskform.requestUrl"></el-input>
            </el-form-item>
            <el-form-item label="请求方式" prop="method">
              <el-select
                style="width: 100%"
                v-model="scheduletaskform.method"
                placeholder="请选择请求方式"
              >
                <el-option label="POST" value="POST"></el-option>
                <el-option label="GET" value="GET"></el-option>
                <el-option label="PUT" value="PUT"></el-option>
                <el-option label="DELETE" value="DELETE"></el-option>
              </el-select>
            </el-form-item>
            <el-form-item label="自定义请求头">
              <el-input
                type="textarea"
                v-model="scheduletaskform.headers"
                placeholder="请输入自定义请求头"
              ></el-input>
              <span
                >请确保请输入json字符串格式的内容正确
                如"[{Authorzation:11111}，{A:111}]后台会自动解析"</span
              >
            </el-form-item>
            <el-form-item label="数据格式">
              <el-radio-group v-model="scheduletaskform.httpContentType">
                <el-radio label="form-data"></el-radio>
                <el-radio label="json-data"></el-radio>
              </el-radio-group>
            </el-form-item>
            <el-form-item label="数据内容">
              <el-input
                type="textarea"
                v-model="scheduletaskform.body"
                placeholder="请输入数据内容"
              ></el-input>
              <span
                >请确保请输入json字符串格式的内容正确
                如"[{Authorzation:11111}，{A:111}]后台会自动解析"</span
              >
            </el-form-item>
            <!-- </el-form> -->
          </el-tab-pane>
          <el-tab-pane label="异常报警通知" name="third">
            <!-- <el-form :model="scheduletaskform" label-width="110px"> -->
            <el-form-item label="监护人">
              <el-select
                multiple
                style="width: 100%"
                v-model="scheduletaskform.keeperInfo"
                placeholder="请选择监护人"
              >
                <el-option
                  v-for="item in userlist"
                  :key="item.id"
                  :label="item.userName"
                  :value="item.id"
                ></el-option>
              </el-select>
            </el-form-item>
            <el-form-item label="通知方式">
              <el-select
                style="width: 100%"
                multiple
                v-model="scheduletaskform.noticetyes"
                placeholder="请选择通知方式"
              >
                <el-option label="邮件" value="main"></el-option>
                <el-option label="短信" value="sms"></el-option>
                <el-option label="站内信" value="signalr"></el-option>
              </el-select>
            </el-form-item>
          </el-tab-pane>
          <el-tab-pane label="执行异常重试" name="fourth">
            <el-form-item label="是否重试">
              <el-switch
                style="width: 100%"
                v-model="scheduletaskform.isHaveRetry"
              ></el-switch>
              <span
                >开启异常重试后在执行接口逻辑返回报错以后会进行重试，目前只支持Http任务调用</span
              >
            </el-form-item>
            <el-form-item
              label="最大重试次数"
              v-show="scheduletaskform.isHaveRetry"
            >
              <el-input
                type="number"
                min="0"
                v-model="scheduletaskform.maxRetryCount"
              ></el-input>
            </el-form-item>
            <el-form-item
              label="重试间隔时间"
              v-show="scheduletaskform.isHaveRetry"
            >
              <el-input
                type="number"
                min="0"
                v-model="scheduletaskform.retryInterval"
              ></el-input>
              <span>重试时间间隔单位是秒</span>
            </el-form-item>
          </el-tab-pane>
        </el-tabs>
      </el-form>
      <div class="modal-footer">
        <el-button type="primary" @click="savescheduletask">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { getalluserlist } from "@/api/identity/user";
import { getscheduleinfo, editscheduletask } from "@/api/scheduletask/index";
import moment from "moment";
import { dateFormat } from "@/utils/formater";
export default {
  data() {
    return {
      callbackmethod: null,
      scheduletaskeditdialogFormVisible: false,
      activeName: "first",

      scheduletaskform: {
        id: "",
        title: "",
        jobGroup: "",
        jobType: 1, //1 是http 任务 2 是程序集任务
        jobTypeName: "Http任务",
        remark: "",
        runLoop: false,
        cronExpression: "",
        assemblyName: "",
        className: "",
        status: 0,
        startDate: null,
        endDate: null,
        isHaveRetry: false,
        maxRetryCount: 0,
        retryInterval: 0,
        isAllowMail: false,
        isAllowSms: false,
        isAllowSignarl: false,
        keeperInfo: [],
        noticetyes: [],
        requestUrl: "",
        method: "POST",
        httpContentType: "form-data",
        headers: "",
        body: "",
      },
      noticetyesList: [
        { value: "main", label: "邮件" },
        { value: "sms", label: "短信" },
        { value: "signalr", label: "站内信" },
      ],
      rules: {
        title: [{ required: true, message: "请输入任务名称", trigger: "blur" }],
        jobGroup: [
          { required: true, message: "请输入任务分组", trigger: "blur" },
        ],
        startDate: [
          {
            required: true,
            message: "请选择日期时间",
            trigger: "change",
          },
        ],
      },
      userlist: [],
    };
  },
  watch: {
    scheduletaskform: {
      handler(newval, oldval) {
        if (newval.runLoop) {
          this.rules.cronExpression = [
            { required: true, message: "请输入Cron表达式", trigger: "blur" },
          ];
        } else {
          delete this.rules["cronExpression"];
        }
        if (newval.jobTypeName == "Http任务") {
          this.rules.requestUrl = [
            { required: true, message: "请输入请求地址", trigger: "blur" },
          ];
          this.rules.method = [
            { required: true, message: "请选择请求方式", trigger: "change" },
          ];
        } else {
          delete this.rules["requestUrl"];
          delete this.rules["method"];
        }
      },
      deep: true,
    },
  },
  methods: {
    moment,
    dateFormat,
    //编辑计划任务弹窗打开
    async createeditscheduletaskdialog(cb, id) {
      this.callbackmethod = cb;
      this.userlist = await getalluserlist();
    //   tempuser.forEach((e) => {
    //     this.userlist.push({
    //       userId: e.id,
    //       userName: e.userName,
    //       email: e.email,
    //       phoneNumber: e.phoneNumber,
    //     });
    //   });
      this.scheduletaskeditdialogFormVisible = true;
      var res = await getscheduleinfo(id);
      this.scheduletaskform.id = res.id;
      this.scheduletaskform.title = res.title;
      this.scheduletaskform.jobGroup = res.jobGroup;
      this.scheduletaskform.jobType = res.jobType;
      this.scheduletaskform.runLoop = res.runLoop;
      this.scheduletaskform.cronExpression = res.cronExpression;
      this.scheduletaskform.startDate = this.dateFormat(
        "YYYY-mm-dd HH:MM:SS",
        new Date(res.startDate)
      );
      this.scheduletaskform.endDate =
        res.endDate != null
          ? this.dateFormat("YYYY-mm-dd HH:MM:SS", new Date(res.endDate))
          : null;
      this.scheduletaskform.remark = res.remark;
      this.scheduletaskform.requestUrl = res.requestUrl;
      this.scheduletaskform.method = res.method;
      this.scheduletaskform.headers = res.headers;
      this.scheduletaskform.body = res.body;
      this.scheduletaskform.isHaveRetry = res.isHaveRetry;
      this.scheduletaskform.maxRetryCount = res.maxRetryCount;
      this.scheduletaskform.retryInterval = res.retryInterval;
      this.scheduletaskform.isAllowMail = res.isAllowMail;
      this.scheduletaskform.isAllowSms = res.isAllowSms;
      this.scheduletaskform.isAllowSignarl = res.isAllowSignarl;
      let keeperInfo1 = [];
      for (let i of res.keeperInfo) {
        let x = this.userlist.find((x) => x.id == i.userId);
        if (x != null) {
          keeperInfo1.push(x.id);
        }
      }
      this.scheduletaskform.keeperInfo = [...keeperInfo1];
      this.scheduletaskform.jobTypeName =
        this.scheduletaskform.jobType == 1 ? "Http任务" : "程序集任务";
      this.scheduletaskform.httpContentType =
        res.contentType == "application/x-www-form-urlencoded"
          ? "form-data"
          : "json-data";
      let noticetyes = [];
      if (this.scheduletaskform.isAllowMail) {
        noticetyes.push("main");
      }
      if (this.scheduletaskform.isAllowSms) {
        noticetyes.push("sms");
      }
      if (this.scheduletaskform.isAllowSignarl) {
        noticetyes.push("signalr");
      }
      this.scheduletaskform.noticetyes = noticetyes;
    },
    //编辑计划任务弹窗关闭
    editscheduletaskmodalclose() {
      this.callbackmethod = null;
      this.activeName = "first";
      this.userlist = [];
      this.scheduletaskeditdialogFormVisible = false;
    },
    //提交计划任务到数据库
    savescheduletask() {
      let param = {
        id: this.scheduletaskform.id,
        title: this.scheduletaskform.title,
        jobGroup: this.scheduletaskform.jobGroup,
        jobType: this.scheduletaskform.jobTypeName == "Http任务" ? 1 : 2,
        remark: this.scheduletaskform.remark,
        runLoop: this.scheduletaskform.runLoop,
        cronExpression: this.scheduletaskform.cronExpression,
        assemblyName: this.scheduletaskform.assemblyName,
        className: this.scheduletaskform.className,
        status: 0,
        startDateStr: this.scheduletaskform.startDate,
        endDateStr: this.scheduletaskform.endDate,
        isHaveRetry: this.scheduletaskform.isHaveRetry,
        maxRetryCount: this.scheduletaskform.maxRetryCount,
        retryInterval: this.scheduletaskform.retryInterval,
        isAllowMail:
          this.scheduletaskform.noticetyes.findIndex((x) => x == "main") != -1
            ? true
            : false,
        isAllowSms:
          this.scheduletaskform.noticetyes.findIndex((x) => x == "sms") != -1
            ? true
            : false,
        isAllowSignarl:
          this.scheduletaskform.noticetyes.findIndex((x) => x == "signalr") !=
          -1
            ? true
            : false,
        requestUrl: this.scheduletaskform.requestUrl,
        method: this.scheduletaskform.method,
        contentType:
          this.scheduletaskform.httpContentType == "form-data"
            ? "application/x-www-form-urlencoded"
            : "application/json",
        headers: this.scheduletaskform.headers,
        body: this.scheduletaskform.body,
      };
      let keeperInfo1 = [];
      for (let i of this.scheduletaskform.keeperInfo) {
        let x = this.userlist.find((x) => x.id == i);
        if (x != null) {
          keeperInfo1.push({
            userId: x.id,
            userName: x.userName,
            mailAddress: x.email,
            phoneNumber: x.phoneNumber,
            weChatId: "",
          });
        }
      }
      param.keeperInfo = [...keeperInfo1];
      let x = param;
      this.$refs.form.validate((valid) => {
        if (valid) {
          editscheduletask(param).then((res) => {
            this.$notify({
              title: "提示",
              message: "编辑计划任务成功",
              type: "success",
            });
            this.callbackmethod();
            this.editscheduletaskmodalclose();
          });
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },
    //验证表单有效性
    checkformValidate() {},
  },
};
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