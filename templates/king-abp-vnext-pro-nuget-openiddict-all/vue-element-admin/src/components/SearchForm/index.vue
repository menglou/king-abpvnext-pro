<template>
  <el-form style="width: 100%" label-width="auto" :model="searform">

    <el-row type="flex" justify="end">
      <el-col :span="1">
        <el-button
          type="primary"
          @click="getalarmdatalist"
        >查询</el-button>
      </el-col>
      <el-col :span="1">
        <el-button @click="ressetBtn">重置</el-button>
      </el-col>
      <el-col :span="1">
        <el-button
          :icon="expandMore ? 'el-icon-arrow-up' : 'el-icon-arrow-down'"
          type="text"
          @click="expandMore = !expandMore"
        >{{ expandMore ? "收起" : "展开" }}</el-button>
      </el-col>
    </el-row>
  </el-form>
</template>

<script>
export default {
  props: {
    mo
  },
  data() {
    return {

    }
  }
}
</script>

<style>
</style>
