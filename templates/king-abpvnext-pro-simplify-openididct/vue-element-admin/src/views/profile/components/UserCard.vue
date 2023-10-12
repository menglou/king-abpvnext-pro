<template>
  <el-card style="margin-bottom: 20px">
    <div slot="header" class="clearfix">
      <span>{{ $t("userCard.aboutMe") }}</span>
    </div>

    <div class="user-profile">
      <div class="box-center">
        <el-avatar :size="80" :src="user.avatar" fit="fill"></el-avatar>
      </div>
      <div />
      <div class="box-center">
        <div class="user-name text-center">{{ user.name }}</div>
        <div class="user-role text-center text-muted">
          {{ user.role | uppercaseFirst }}
        </div>
      </div>
      <div class="box-center">
        <el-upload
          action
          name="file"
          :before-upload="beforeUpload"
          :http-request="uploadAvatar"
          :show-file-list="false"
        >
          <el-button type="primary" icon="el-icon-upload">{{
            $t("userCard.changeAvatar")
          }}</el-button>
        </el-upload>
      </div>
    </div>
    <div class="user-bio">
      <div class="user-education user-bio-section">
        <div class="user-bio-section-header">
          <span>{{ $t("userCard.personalIntroduction") }}</span>
        </div>
        <div class="user-bio-section-body">
          <div class="text-muted">
            {{
              user.introduction
                ? user.introduction
                : $t("userCard.personalIntroductionContent")
            }}
          </div>
        </div>
      </div>
    </div>
  </el-card>
</template>

<script>
import PanThumb from "@/components/PanThumb";
import { getFilePathByName } from "@/utils/abp";
export default {
  components: { PanThumb },
  props: {
    user: {
      type: Object,
      default: () => {
        return {
          name: "",
          userName: "",
          email: "",
          avatar: "",
          role: "",
          phoneNumber: "",
          introduction: "",
        };
      },
    },
  },
  data() {
    return {
      loading: false,
    };
  },
  mounted() {},
  methods: {
    getFilePathByName,
    beforeUpload(file) {
      // TODO: Image format verification
    },
    uploadAvatar(data) {
      const fd = new FormData();
      fd.append("file", data.file);

      this.getBase64(data.file).then((res) => {
        this.user.avatar = res;
        const userInfo = {
          userName: this.user.userName,
          email: this.user.email,
          name: this.user.name,
          phoneNumber: this.user.phoneNumber,
          extraProperties: {
            Avatar: res,
            Introduction: this.user.introduction,
          },
        };
        this.loading = true;
        this.$store.dispatch("user/setUserInfo", userInfo).then((res) => {
          this.loading = false;
          this.$notify({
            title: "提示",
            message:"头像上传成功！",
            type: "success",
            duration: 2000,
          });
        });
      });
    },

    //图片文件转base64方法
    getBase64(file) {
      return new Promise(function (resolve, reject) {
        const reader = new FileReader();
        let imgResult = "";
        reader.readAsDataURL(file);
        reader.onload = function () {
          imgResult = reader.result;
        };
        reader.onerror = function (error) {
          reject(error);
        };
        reader.onloadend = function () {
          resolve(imgResult);
        };
      });
    },
  },
};
</script>

<style scoped>
.box-center {
  margin: 0 auto;
  display: table;
}

.text-muted {
  color: #777;
}

.user-name {
  font-weight: bold;
  text-align: center;
}
.box-center {
  padding-top: 10px;
}
.user-role {
  padding-top: 10px;
  font-weight: 400;
  font-size: 14px;
}
.box-socia {
  padding-top: 30px;
}
.el-table {
  border-top: 1px solid #dfe6ec;
}
.user-follow {
  padding-top: 20px;
}

span {
  padding-left: 4px;
}
.user-bio-section {
  font-size: 14px;
  padding: 15px 0;
}
.user-bio-section-header {
  border-bottom: 1px solid #dfe6ec;
  padding-bottom: 10px;
  margin-bottom: 10px;
  font-weight: bold;
}
.user-bio {
  margin-top: 20px;
  color: #606266;
}
</style>

