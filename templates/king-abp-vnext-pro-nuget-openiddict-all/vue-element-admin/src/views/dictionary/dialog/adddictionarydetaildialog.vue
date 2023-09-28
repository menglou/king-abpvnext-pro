<template>
  <div>
    <!-- 字典详情列表弹窗 -->
    <vxe-modal
      v-model="dictionarydetailadddialogFormVisible"
      type="modal "
      title="添加字典详情列表"
      :position="{ top: 40 }"
      width="850"
      @close="closedictionarydetail"
    >
      <template v-slot>
        <div style="margin: 5px 30px 5px 5px">
          <vxe-toolbar ref="xToolbar2" custom>
            <template #buttons>
              <el-button
                v-if="checkPermission('Dictionary.Detail.Create')"
                type="primary"
                icon="el-icon-plus"
                @click="adddictionarydetaildialogdisplay"
                >新增</el-button
              >
            </template>
          </vxe-toolbar>
          <vxe-table
            id="dictionary"
            :data="datalist"
            auto-resize
            align="center"
            :custom-config="{ storage: true }"
            border="inner"
            max-height="550"
          >
            <vxe-table-column type="seq" width="60" />
            <vxe-table-column title="显示名称" min-width="150" field="label">
            </vxe-table-column>
            <vxe-table-column title="值" min-width="100" field="value" />
            <vxe-table-column title="字典排序" min-width="100" field="sort" />
            <vxe-table-column title="操作" min-width="80">
              <template v-slot="{ row }">
                <el-button
                  type="text"
                  @click="editdictionarydetail(row)"
                  icon="el-icon-edit"
                  >修改</el-button
                >
                <el-button
                  type="text"
                  @click="deletedictionarydetail(row)"
                  icon="el-icon-delete"
                  >删除</el-button
                >
              </template>
            </vxe-table-column>
          </vxe-table>
          <vxe-pager
            :current-page.sync="tablePage.currentPage"
            :page-size.sync="tablePage.pageSize"
            :total="tablePage.totalResult"
            :layouts="[
              'PrevJump',
              'PrevPage',
              'JumpNumber',
              'NextPage',
              'NextJump',
              'Sizes',
              'FullJump',
              'Total',
            ]"
            @page-change="handlePageChange"
          />
        </div>
        <div class="modal-footer">
          <el-button type="primary" @click="closedictionarydetail"
            >关闭</el-button
          >
        </div>
      </template>
    </vxe-modal>
    <!-- 添加字典详情弹窗 -->
    <vxe-modal
      v-model="dictionarydetailmodeladddialogFormVisible"
      type="modal "
      title="添加字典详情"
      :position="{ top: 40 }"
      width="650"
      @close="adddictionarymodalclose"
    >
      <template v-slot>
        <div style="margin: 5px 30px 5px 5px">
          <el-form ref="form" :model="form" :rules="rules" label-width="150px">
            <el-row>
              <el-col :span="24">
                <el-form-item label="显示名称" prop="label">
                  <el-input v-model="form.label" placeholder="请输入显示名称" />
                </el-form-item>
              </el-col>
              <el-col :span="24">
                <el-form-item label="值" prop="value">
                  <el-input v-model="form.value" placeholder="请输入值" />
                </el-form-item>
              </el-col>
              <el-col :span="24">
                <el-form-item label="排序">
                  <el-input type="number" v-model="form.sort" />
                </el-form-item>
              </el-col>
            </el-row>
          </el-form>
        </div>
        <div class="modal-footer">
          <el-button type="primary" @click="savedictionarydetail"
            >保存</el-button
          >
        </div>
      </template>
    </vxe-modal>

    <!-- 修改字典详情弹窗 -->
    <vxe-modal
      v-model="dictionarydetailmodeleditdialogFormVisible"
      type="modal "
      title="修改字典详情"
      :position="{ top: 40 }"
      width="650"
      @close="editdictionarymodalclose"
    >
      <template v-slot>
        <div style="margin: 5px 30px 5px 5px">
          <el-form
            ref="editform"
            :model="editform"
            :rules="rules"
            label-width="150px"
          >
            <el-row>
              <el-col :span="24">
                <el-form-item label="显示名称" prop="label">
                  <el-input
                    v-model="editform.label"
                    placeholder="请输入显示名称"
                  />
                </el-form-item>
              </el-col>
              <el-col :span="24">
                <el-form-item label="值" prop="value">
                  <el-input v-model="editform.value" placeholder="请输入值" />
                </el-form-item>
              </el-col>
              <el-col :span="24">
                <el-form-item label="排序">
                  <el-input type="number" v-model="editform.sort" />
                </el-form-item>
              </el-col>
            </el-row>
          </el-form>
        </div>
        <div class="modal-footer">
          <el-button type="primary" @click="submiteditdictionarydetail"
            >保存</el-button
          >
        </div>
      </template>
    </vxe-modal>
  </div>
</template>

<script>
import {
  getdictionarydetailpagelistbyId,
  adddictionarydetail,
  editdictionarydetail,
  deletedictionarydetail,
  getdictionarydetailifo,
} from "@/api/dictionary/index";
import { checkPermission } from "@/utils/abp";
export default {
  data() {
    return {
      dictionarydetailadddialogFormVisible: false,
      callbackmethod: null,
      datalist: [],

      tablePage: {
        currentPage: 1,
        pageSize: 10,
        totalResult: 0,
      },

      dictionarydetailmodeladddialogFormVisible: false,
      form: {
        dataDictionaryId: "",
        label: "",
        value: "",
        sort: 0,
      },
      rules: {
        label: [{ required: true, message: "请输入显示名称", trigger: "blur" }],
        value: [{ required: true, message: "请输入值", trigger: "blur" }],
      },

      dictionarydetailmodeleditdialogFormVisible: false,
      editform: {
        id: "",
        dataDictionaryId: "",
        label: "",
        value: "",
        sort: 0,
      },
    };
  },
  methods: {
    checkPermission,
    //打开添加字典详情列列表弹窗
    async createadddictionarydetaildialog(cb, dictionaryid) {
      debugger;
      this.callbackmethod = cb;
      this.form.dataDictionaryId = dictionaryid;
      await this.getdictionartdetaillist();
      this.dictionarydetailadddialogFormVisible = true;
    },
    //关闭字典详情列表
    closedictionarydetail() {
      this.adddictionarymodalclose();
      this.form.dataDictionaryId = "";
      this.datalist = [];
      this.dictionarydetailadddialogFormVisible = false;
    },
    //获取字典详情列表
    async getdictionartdetaillist() {
      const { currentPage, pageSize } = this.tablePage;
      let param = {
        DictionaryId: this.form.dataDictionaryId,
        SkipCount: (currentPage - 1) * pageSize,
        MaxResultCount: pageSize,
      };
      let res = await getdictionarydetailpagelistbyId(param);
      this.datalist = res.items;
      this.tablePage.totalResult = res.totalCount;
    },
    handlePageChange({ currentPage, pageSize }) {
      this.tablePage.currentPage = currentPage;
      this.tablePage.pageSize = pageSize;
      this.getdictionartdetaillist();
    },

    //添加字典详情
    adddictionarydetaildialogdisplay() {
      this.dictionarydetailmodeladddialogFormVisible = true;
    },
    //关闭字典详情
    adddictionarymodalclose() {
      this.dictionarydetailmodeladddialogFormVisible = false;
      this.$refs.form.resetFields();
    },
    //保存字典详情
    savedictionarydetail() {
      this.$refs.form.validate((valid) => {
        if (valid) {
          adddictionarydetail(this.form).then((res) => {
            this.$notify({
              title: "提示",
              message: "添加字典详情成功",
              type: "success",
            });
            this.adddictionarymodalclose();
            this.getdictionartdetaillist();
          });
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },

    async editdictionarydetail(row) {
      let res = await getdictionarydetailifo(row.id);
      this.editform.id = res.id;
      this.editform.dataDictionaryId = res.dataDictionaryId;
      this.editform.label = res.label;
      this.editform.value = res.value;
      this.editform.sort = res.sort;
      this.dictionarydetailmodeleditdialogFormVisible = true;
    },

    editdictionarymodalclose() {
      this.dictionarydetailmodeleditdialogFormVisible = false;
      this.$refs.editform.resetFields();
      this.editform.id = "";
      this.editform.dataDictionaryId = "";
    },
    submiteditdictionarydetail() {
      this.$refs.editform.validate((valid) => {
        if (valid) {
          editdictionarydetail(this.editform.id, this.editform).then((res) => {
            this.$notify({
              title: "提示",
              message: "修改字典详情成功",
              type: "success",
            });
            this.editdictionarymodalclose();
            this.getdictionartdetaillist();
          });
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },

    deletedictionarydetail(row) {
      this.$confirm("此操作将永久删除该文件, 是否继续?", "提示", {
        confirmButtonText: "确定",
        cancelButtonText: "取消",
        type: "warning",
      })
        .then(() => {
          deletedictionarydetail(row.id).then((res) => {
            this.$notify({
              title: "提示",
              message: "删除字典详情成功",
              type: "success",
            });
            this.getdictionartdetaillist();
          });
        })
        .catch(() => {
          
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