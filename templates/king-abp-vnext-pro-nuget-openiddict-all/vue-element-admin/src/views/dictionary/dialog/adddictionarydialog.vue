<template>
  <vxe-modal
    v-model="dictionaryadddialogFormVisible"
    type="modal "
    title="添加字典"
    :position="{ top: 40 }"
    width="650"
    @close="adddictionarymodalclose"
  >
    <template v-slot>
      <div style="margin: 5px 30px 5px 5px">
        <el-form ref="form" :model="form" :rules="rules" label-width="150px">
          <el-row>
            <el-col :span="24">
              <el-form-item label="字典名称" prop="name">
                <el-input v-model="form.name" placeholder="请输入字典名称" />
              </el-form-item>
            </el-col>
            <el-col :span="24">
              <el-form-item label="备注">
                <el-input
                  type="textarea"
                  v-model="form.description"
                  placeholder="请输入备注"
                />
              </el-form-item>
            </el-col>
          </el-row>
        </el-form>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="savedictionary">保存</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { adddictionary } from "@/api/dictionary/index";
export default {
  data() {
    return {
      dictionaryadddialogFormVisible: false,
      callbackmethod: null,
      form: {
        name: "",
        description: "",
        sort: 0,
      },
      rules: {
        name: [{ required: true, message: "请输入字典名称", trigger: "blur" }],
      },
    };
  },
  methods: {
    createdictionarydialog(cb) {
      this.callbackmethod = cb;
      this.dictionaryadddialogFormVisible = true;
    },
    adddictionarymodalclose() {
      this.callbackmethod = null;
      this.form.name = "";
      this.form.description = "";
      this.form.sort = 0;
      this.dictionaryadddialogFormVisible = false;
    },
    savedictionary() {
      this.$refs.form.validate((valid) => {
        if (valid) {
          adddictionary(this.form).then((res) => {
            this.$notify({
              title: "提示",
              message: "添加字典成功",
              type: "success",
            });
            this.callbackmethod();
            this.adddictionarymodalclose();
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