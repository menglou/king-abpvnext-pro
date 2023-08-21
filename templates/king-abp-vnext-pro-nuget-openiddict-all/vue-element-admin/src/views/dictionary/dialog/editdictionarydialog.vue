<template>
  <vxe-modal
    v-model="dictionaryeditdialogFormVisible"
    type="modal "
    title="添加字典"
    :position="{ top: 40 }"
    width="650"
    @close="editdictionarymodalclose"
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
import { getdictionaryinfo, editdictionaryinfo } from "@/api/dictionary/index";
export default {
  data() {
    return {
      dictionaryeditdialogFormVisible: false,
      callbackmethod: null,
      form: {
        id: "",
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
    async editdictionarydialog(cb, id) {
      this.callbackmethod = cb;
      let res = await getdictionaryinfo(id);
      this.form.id = res.id;
      this.form.name = res.name;
      this.form.description = res.description;
      this.form.sort = res.sort;
      this.dictionaryeditdialogFormVisible = true;
    },

    editdictionarymodalclose() {
      this.dictionaryeditdialogFormVisible = false;
      this.form.id = "";
      this.form.name = "";
      this.form.description = "";
      this.form.sort = "";
    },

    savedictionary() {
      this.$refs.form.validate((valid) => {
        if (valid) {
          editdictionaryinfo(this.form.id, this.form).then((res) => {
            this.$notify({
              title: "提示",
              message: "修改字典成功",
              type: "success",
            });
            this.callbackmethod();
            this.editdictionarymodalclose();
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