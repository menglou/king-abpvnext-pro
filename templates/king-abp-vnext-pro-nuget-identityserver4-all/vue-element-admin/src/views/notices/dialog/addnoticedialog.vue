<template>
  <vxe-modal
    v-model="notcieadddialogFormVisible"
    type="modal "
    title="添加公告"
    :position="{ top: 40 }"
    width="650"
    @close="addnoticemodalclose"
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
                    >{{ dict.label }}</el-radio
                  >
                </el-radio-group>
              </el-form-item>
            </el-col>
            <el-col :span="24">
              <el-form-item label="是否创建并发布">
                <el-switch v-model="form.isCreate"></el-switch>
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
        <el-button type="primary" @click="savenotice">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import Editor from "@/components/Editor";
import { sendandcreatenotice } from "@/api/notcie";
export default {
  components: {
    Editor,
  },
  data() {
    return {
      callbackmethod: null,
      notcieadddialogFormVisible: false,
      form: {
        title: "",
        status: "正常",
        content: "",
        isCreate: false,
      },
      statusOptions: [
        { label: "正常", value: 0 },
        { label: "关闭", value: 1 },
      ],
      rules: {
        title: [
          { required: true, message: "公告标题不能为空", trigger: "blur" },
        ],
      },
    };
  },
  methods: {
    async createaddnoticedialog(cb) {
      this.callbackmethod = cb;
      this.notcieadddialogFormVisible = true;
    },
    addnoticemodalclose() {
      this.callbackmethod = null;
      this.$refs.form.resetFields();
      this.form.status = "正常";
      this.form.isCreate = false;
      this.form.content = "";
      this.notcieadddialogFormVisible = false;
    },

    savenotice() {
      let param = this.form;
      param.status = this.form.status == "正常" ? 0 : 1;
      this.$refs.form.validate((valid) => {
        if (valid) {
          sendandcreatenotice(param).then((res) => {
            this.$notify({
              title: "提示",
              message: "添加通告成功",
              type: "success",
            });
            this.callbackmethod();
            this.addnoticemodalclose();
          });
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },
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
</style>