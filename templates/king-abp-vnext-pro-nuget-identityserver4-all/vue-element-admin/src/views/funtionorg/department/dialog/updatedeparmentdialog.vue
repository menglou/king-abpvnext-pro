<template>
  <vxe-modal
    v-model="departmenteditdialogFormVisible"
    type="modal "
    title="编辑部门"
    :position="{ top: 40 }"
    width="550"
    @close="editdepartmentmodalclose"
  >
    <template v-slot>
      <div class="modal-top">
        <el-form
          :model="editForm"
          :rules="editFormrules"
          ref="editForm"
          label-width="250px"
        >
          <el-form-item
            v-if="editForm.curparentId.length === 0 ? false : true"
            label="当前所属父组织"
            label-width="120px"
            prop="parentName"
          >
            <el-select
              v-model="editForm.curparentId"
              disabled
              style="width: 100%"
            >
              <el-option
                v-for="item in departmentOptions"
                :key="item.id"
                :label="item.displayName"
                :value="item.id"
              >
              </el-option>
            </el-select>
          </el-form-item>
          <el-form-item
            label="更换所属父组织"
            label-width="120px"
            prop="parentName"
          >
            <el-select
              v-model="editForm.parentId"
              style="width: 100%"
              filterable
            >
              <el-option
                v-for="item in departmentOptions"
                :key="item.id"
                :label="item.displayName"
                :value="item.id"
              >
              </el-option>
            </el-select>
          </el-form-item>
          <el-form-item label="组织名称" label-width="120px" prop="displayName">
            <el-input
              v-model="editForm.displayName"
              autocomplete="off"
            ></el-input>
          </el-form-item>
        </el-form>
      </div>
      <div class="modal-footer">
        <el-button type="primary" @click="confirmeditForm">确 定</el-button>
      </div>
    </template>
  </vxe-modal>
</template>

<script>
import {
  getdepartmentUnit,
  getalldepartmentUnit,
  editdepartmentUnit,
  movedepartmentUnit,
} from "@/api/department/index";
import moment from "moment";
export default {
  data() {
    return {
      callbackmethod: null,
      departmenteditdialogFormVisible: false,
      id: "",
      editForm: {
        curparentId: "",
        parentId: "",
        parentName: "",
        displayName: "",
        concurrencyStamp: "",
      },
      departmentOptions: [],
      editFormrules: {
        displayName: [
          { required: true, message: "请输入部门名称", trigger: "blur" },
        ],
      },
    };
  },
  methods: {
    moment,
    async editdepartmentdialog(cb, row) {
      this.callbackmethod = cb;
      this.id = row.id;
      this.departmentOptions = await getalldepartmentUnit();
      var res = await getdepartmentUnit(row.id);
      this.editForm.concurrencyStamp = res.concurrencyStamp;
      this.editForm.displayName = row.displayName;
      if (row.parentId != null) {
        var res = await getdepartmentUnit(row.parentId);
        this.editForm.curparentId = row.parentId;
        this.editForm.parentId = row.parentId;
      }

      // if (row) {
      //   this.id = row.id;
      //   this.editForm.parentId = row.parentId;
      //   this.editForm.parentId = row.parentId;
      //   this.editForm.displayName = row.displayName;
      // }
      this.departmenteditdialogFormVisible = true;
    },
    confirmeditForm() {
      this.$refs.editForm.validate((valid) => {
        if (valid) {
          let param = {
            displayName: this.editForm.displayName,
            concurrencyStamp: this.editForm.concurrencyStamp,
          };
          const param2 = {
            id: this.id,
            parentId:
              this.editForm.parentId == "" ? null : this.editForm.parentId,
          };
          if (param2.id == param2.parentId) {
            this.$notify({
              title: "提示",
              message: "当前部门不可移动到自己",
              type: "warning",
            });
          } else {
            editdepartmentUnit(this.id, param).then((res) => {
              if (res != null) {
                movedepartmentUnit(param2).then((res) => {
                  this.departmenteditdialogFormVisible = false;
                  this.$notify({
                    title: "提示",
                    message: "编辑部门成功",
                    type: "success",
                  });
                  this.callbackmethod();
                  this.editdepartmentmodalclose();
                });
              }
            });
          }
        } else {
          return false;
        }
      });
    },
    editdepartmentmodalclose() {
      this.callbackmethod = null;
      this.$refs.editForm.resetFields();
      this.editForm.parentId = "";
      this.editForm.parentName = "";
      this.editForm.displayName = "";
      this.departmenteditdialogFormVisible = false;
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
