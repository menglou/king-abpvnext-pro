<template>
  <div class="container">
    <div class="container-header">
      <div v-for="(item, index) in messageList" :key="index" class="content">
        <div class="row1">
          <el-popover trigger="hover" placement="bottom" width="220">
            <p>{{ item.title }}</p>
            <div slot="reference" class="textBox">
              {{ item.title }}
            </div>
          </el-popover>
        </div>
        <div class="row2">
          <el-tag size="mini" class="tag" :color="item.read ? 'green' : 'red'">
            {{ item.read ? "已读" : "未读" }}
          </el-tag>
          <el-tag
            v-if="!item.read"
            size="mini"
            style="margin-left: 10px"
            class="tag"
            color="green"
            @click="onSetRead(item)"
          >
            {{ "标记为已读" }}
          </el-tag>
        </div>
        <div class="row3">
          <el-popover trigger="hover" placement="bottom" width="220">
            <p>{{ item.content }}</p>
            <div slot="reference" class="textBox">
              {{ item.content }}
            </div>
          </el-popover>
        </div>
        <div class="row4">
          <div class="row4-content">
            {{ moment(item.creationTime).format("YYYY-MM-DD HH:mm:ss") }}
          </div>
          <div class="row4-content">
            <el-button size="mini" type="primary">处理</el-button>
            <el-button size="mini" type="primary">查看</el-button>
          </div>
        </div>
      </div>
    </div>
    <div
      v-if="messageList.length > 0"
      class="foot-box"
      @click="onGoToGiteeClick"
    >
      前往消息中心
    </div>
  </div>
</template>

<script>
import moment from 'moment'
import { setisread, getcommonnoticelist } from '@/api/notcie'
export default {
  name: 'MessageList',
  props: {
    messageList: {
      Type: Array,
      default: () => {
        return []
      }
    }
  },
  methods: {
    moment,
    onSetRead(item) {
      setisread({ id: item.id }).then(() => {
        getcommonnoticelist({ Status: 0, Title: '' }).then((res) => {
          this.messageList = [...res]
        })
      })
    },
    onGoToGiteeClick() {}
  }
}
</script>

<style scoped lang="scss">
.container {
  width: 100%;
  display: flex;
  align-content: flex-start;
  flex-direction: column;
  justify-content: center;
  .container-header {
    width: 100%;
    max-height: 750px;
    overflow-y: auto;
    .content {
      border: 1px solid #eee;
      margin: 5px;
      padding: 5px;
      .row1 {
        font-size: 15px;
        height: 30px;
        line-height: 30px;
        cursor: pointer;
        .textBox {
          -webkit-line-clamp: 1;
          overflow: hidden;
          display: -webkit-box;
          -webkit-box-orient: vertical;
          white-space: normal;
        }
      }
      .row2 {
        font-size: 12px;
        color: #fff;
        cursor: pointer;
        .tag {
          color: #fff;
          font-weight: normal;
        }
        ::v-deep .el-tag {
          border-color: transparent;
        }
      }
      .row3 {
        font-size: 15px;
        padding-top: 5px;
        padding-bottom: 5px;
        cursor: pointer;
        .textBox {
          -webkit-line-clamp: 1;
          overflow: hidden;
          display: -webkit-box;
          -webkit-box-orient: vertical;
          white-space: normal;
        }
      }
      .row4 {
        display: flex;
        flex-direction: row;
        width: 100%;
        height: 30px;
        justify-content: space-between;
        .row4-content {
          font-size: 13px;
          height: 30px;
          line-height: 30px;
        }
      }
    }
  }
  .foot-box {
    margin-top: 5px;
    height: 35px;
    color: #1890ff;
    font-size: 13px;
    cursor: pointer;
    opacity: 0.8;
    display: flex;
    align-items: center;
    justify-content: center;
    border-top: 1px solid #ebeef5;
    &:hover {
      opacity: 1;
    }
  }
}
</style>
