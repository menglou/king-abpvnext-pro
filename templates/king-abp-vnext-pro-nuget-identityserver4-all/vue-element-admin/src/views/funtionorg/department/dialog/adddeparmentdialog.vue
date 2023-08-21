<template>
  <vxe-modal
    v-model="departmentadddialogFormVisible"
    type="modal "
    title="添加部门"
    :position="{ top: 40 }"
    width="550"
    @close="adddepartmentmodalclose"
  >
    <template v-slot>
      <div class="modal-top">
        <el-form
          :model="addForm"
          :rules="addFormrules"
          ref="addForm"
          label-width="250px"
        >
          <el-form-item
            v-if="addForm.parentId.length === 0 ? true : true"
            label="所属父组织"
            label-width="100px"
            prop="parentName"
          >
            <el-input
              disabled
              v-model="addForm.parentName"
              autocomplete="off"
            ></el-input>
          </el-form-item>
          <el-form-item label="组织名称" label-width="100px" prop="displayName">
            <el-input
              v-model="addForm.displayName"
              autocomplete="off"
            ></el-input>
          </el-form-item>
        </el-form>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="confirmaddForm">确 定</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import { adddepartment } from "@/api/department/index";
import moment from "moment";
export default {
  data() {
    return {
      callbackmethod: null,
      departmentadddialogFormVisible: false,
      addForm: {
        parentId: "",
        parentName: "",
        displayName: "",
      },
      addFormrules: {
        displayName: [
          { required: true, message: "请输入部门名称", trigger: "blur" },
        ],
      },
    };
  },
  methods: {
    moment,
    createdepartmentdialog(cb, row) {
      this.callbackmethod = cb;
      if (row) {
        this.addForm.parentId = row.id;
        this.addForm.parentName = row.displayName;
      }
      this.departmentadddialogFormVisible = true;
    },
    confirmaddForm() {
      this.$refs.addForm.validate((valid) => {
        if (valid) {
          let param = {
            displayName: this.addForm.displayName,
          };
          if (this.addForm.parentId.length != 0) {
            param.parentId = this.addForm.parentId;
          } else {
            //param.parentId = null;
          }
          adddepartment(param).then((res) => {
            if (res != null) {
              this.departmentadddialogFormVisible = false;
              this.$notify({
                title: "提示",
                message: "添加部门成功",
                type: "success",
              });
              this.callbackmethod();
              this.adddepartmentmodalclose();
            }
          });
        } else {
          return false;
        }
      });
    },
    adddepartmentmodalclose() {
      this.callbackmethod = null;
      this.$refs.addForm.resetFields();
      this.addForm.parentId = "";
      this.addForm.parentName = "";
      this.addForm.displayName = "";
      this.departmentadddialogFormVisible = false;
    },
  },
};
</script>


<style scoped>
.modal-top {
  margin: 25px 35px 15px 30px;
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
