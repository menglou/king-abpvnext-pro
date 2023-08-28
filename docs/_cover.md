
<div class="cover-container">
  <div>
    <img src="./_media/icon.jpg" align="center" style="border-radius:6px">
  </div>
  <div style="margin-top:15px">
    <h1>
     <a>
       <span style="">King-AbpVnext-Pro</span>
       <small>4.0.2</small>
     </a>
    </h1>
  </div>
  <div>
     <h3>一个神奇的开箱即用的中后台管理系统解决方案</h3>
  </div>
  <div class="btndiv">
      <span style="margin-right:10px;border: 1px solid #42b983;">
         <a href="https://github.com/menglou/king-abpvnext-pro.git" >Github</a>
      </span>
      <span style="margin-left:10px;background-color:#42b983">
        <a href="#/zh-cn/introduce" >快速上手 →</a>
      </span>
  </div>
  <div class="contentdiv">
       <div class="line"></div>
       <div class="introducediv">
           <div class="itemdiv">
             <div class="itemcontent">
                <h2>丰富功能</h2>
                <p>提炼了典型的业务模型，提供了丰富的模块</p>
             </div>
              <div class="itemcontent">
                <h2>模块化</h2>
                <p>除了AbpVnext 内置的丰富的模块，本系统根据业务模型提炼出了支付，计划任务，工作流等一些列模块</p>
             </div>
              <div class="itemcontent">
                <h2>最新技术栈</h2>
                <p>前端使用 vue/vuex/vue-router/element 等前端前沿技术开发，后端基于AbpVnext框架</p>
             </div>
           </div>
           <div class="itemdiv">
             <div class="itemcontent">
                <h2>权限验证</h2>
                <p>根据权限动态加载路由，渲染侧边栏,且权限管控到按钮级别</p>
             </div>
              <div class="itemcontent">
                <h2>国际化</h2>
                <p>内建业界通用的国际化方案</p>
             </div>
              <div class="itemcontent">
                <h2>可视化配置中心</h2>
                <p>放弃了以往通过appsetting.josn 配置，通过可视化界面完成配置，且可以控制权限</p>
             </div>
           </div>
       </div>
       <div class="line"></div>
  </div>
</div> 


<style>
  section.cover{
      align-items:flex-start !important;
      padding-top:140px
  }
  .cover-container{
      display:flex;
      flex-direction: column;
      justify-content: center;
      align-items:center ;
  }
  .btndiv{
      height:50px;
      display:inline-flex;
      flex-direction: row;
      justify-content: space-between;
      margin-top:15px;
  }
  .btndiv span {
      border-radius:6px;
      height:50px;
      width:150px;
      text-align:center;
      line-height:50px;
      color:#fff;
      font-size:20px
  }
 
  .contentdiv{
      display:inline-flex;
      flex-direction: column;
      justify-content: center;
      align-items:center ;
      width:900px;
      margin-top:60px;
      
  }
  .line{
      width:900px;
      height:1px;
      background-color:black;
  }
  .introducediv{
      width:900px;
      display:flex;
      flex-direction: column;
      justify-content: center;
      align-items:center ;
  }
  .itemdiv{
     width:900px;
    display:flex;
    flex-wrap: wrap;
    align-items: flex-start;
    align-content: stretch;
    justify-content: space-between;
  }
  .itemcontent{
    flex-grow: 1;
    flex-basis: 30%;
    max-width: 30%;
  }
  .itemcontent p{
    color:#4e6e8e;
     text-align: left;
  }

  .itemcontent h2{
     text-align: left;
  }
</style> 
