<template>
  <el-tabs v-model="activeName">
    <el-tab-pane label="消息" name="first" class="el-tab-content">
      <message-list
        v-if="messagelist.length > 0"
        :messageList="messagelist"
      ></message-list>
      <el-empty v-else description="暂无数据"></el-empty>
    </el-tab-pane>
    <el-tab-pane label="通知" name="second" class="el-tab-content">
      <notice-list
        v-if="notificationlist.length > 0"
        :noticeList="notificationlist"
      ></notice-list>
      <el-empty v-else description="暂无数据"></el-empty>
    </el-tab-pane>
  </el-tabs>
</template>

<script>
import NoticeList from "./noticelist.vue";
import MessageList from "./messagelist.vue";
export default {
  components: {
    NoticeList,
    MessageList,
  },
  props: {
    messagelist: {
      type: Array,
      default: () => [],
    },
    notificationlist: {
      type: Array,
      default: () => [],
    },
  },
  data() {
    return {
      activeName: "first",
    };
  },
  methods: {
    onGoToGiteeClick() {},
  },
};
</script>

<style  lang="scss" scoped>
::v-deep(.el-empty__description p) {
  font-size: 13px;
}

::v-deep .el-badge__content.is-fixed.is-dot {
  top: 12px !important;
}
.el-tab-content {
  overflow: hidden;
}
::v-deep .el-tabs__item {
  font-size: 13px;
  height: 35px;
  line-height: 35px;
}
::v-deep .el-tabs__active-bar {
  height: 1.5px;
}
::v-deep .el-tabs__nav-wrap::after {
  height: 1px !important;
}
</style>