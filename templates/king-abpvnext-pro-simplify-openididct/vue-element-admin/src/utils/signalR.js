// 官方文档：https://docs.microsoft.com/zh-cn/aspnet/core/signalr/javascript-client?view=aspnetcore-6.0&viewFallbackFrom=aspnetcore-2.2&tabs=visual-studio
import * as signalR from '@microsoft/signalr'
import store from '../store'
import { getToken } from '@/utils/auth'
import { Notification } from 'element-ui'

export default {
  // signalR对象
  SR: {},
  // 失败连接重试次数
  failNum: 4,
  baseUrl: '',
  init(url) {
    const connection = new signalR.HubConnectionBuilder()
      .withUrl(url, {
        accessTokenFactory: () => getToken(),
        skipNegotiation: true,
        transport: signalR.HttpTransportType.WebSockets
      })
    // .withUrl(url)//hub地址,我们的集线器是userhub对应的地址http://localhost:5107/signalr-hubs/user
    // .withUrl(url, { accessTokenFactory: () => getToken() })
      .withAutomaticReconnect() // 自动重新连接
      .configureLogging(signalR.LogLevel.Warning)
      .build()
    this.SR = connection
    // 断线重连
    connection.onclose(async() => {
      console.log('断开连接了')
      console.assert(connection.state === signalR.HubConnectionState.Disconnected)
      // 建议用户重新刷新浏览器
      await this.start()
    })

    connection.onreconnected(() => {
      console.log('断线重新连接成功')
    })
    this.receiveMsg(connection)

    // 接收普通文本消息
    this.SR.on('ReceiveTextMessageAsync', this.ReceiveTextMessageHandlerAsync)
    // 接收广播消息
    this.SR.on('ReceiveBroadCastMessageAsync', this.ReceiveBroadCastMessageHandlerAsync)
    // 启动
    // this.start();
  },
  /**
     * 调用 this.signalR.start().then(async () => { await this.SR.invoke("method")})
     * @returns
     */
  async start() {
    var that = this

    try {
      // 使用async和await 或 promise的then 和catch 处理来自服务端的异常
      await this.SR.start()
      // console.assert(this.SR.state === signalR.HubConnectionState.Connected);
      console.log('signalR 连接成功了', this.SR.state)
      return true
    } catch (error) {
      that.failNum--
      console.log(`失败重试剩余次数${that.failNum}`, error)
      if (that.failNum > 0) {
        setTimeout(async() => {
          await this.SR.start()
        }, 5000)
      }
      return false
    }
  },
  /**
   * 关闭SignalR连接
   */
  closeConnect() {
    if (this.SR) {
      this.SR.stop()
    }
  },
  // 接收消息处理
  receiveMsg(connection) {
    connection.on('onlineNum', (data) => {
      store.dispatch('signalr/changeOnlineNum', data)
    })
  },

  /**
 * 接收文本消息
 * @param message 消息体
 */
  ReceiveTextMessageHandlerAsync(message) {
    console.log(message)
    if (message.messageLevel == 10) {
      Notification.warning({
        message: message.title,
        description: message.content
      })
    } else if (message.messageLevel == 20) {
      Notification.info({
        message: message.title,
        description: message.content
      })
    } else if (message.messageLevel == 30) {
      Notification.error({
        message: message.title,
        description: message.content
      })
    } else {
      Notification.info({
        message: message.title,
        description: message.content
      })
    }
  },

  /**
     * 接收广播消息
     * @param message 消息体
     */
  ReceiveBroadCastMessageHandlerAsync(message) {
    if (message.messageLevel == 10) {
      Notification.warning({
        message: message.title,
        description: message.content
      })
    } else if (message.messageLevel == 20) {
      Notification.info({
        message: message.title,
        description: message.content
      })
    } else if (message.messageLevel == 30) {
      Notification.error({
        message: message.title,
        description: message.content
      })
    } else {
      Notification.info({
        message: message.title,
        description: message.content
      })
    }
  }

}
