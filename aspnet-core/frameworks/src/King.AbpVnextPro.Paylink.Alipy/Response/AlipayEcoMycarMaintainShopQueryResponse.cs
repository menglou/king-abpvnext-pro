﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainShopQueryResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainShopQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店详细地址，地址字符长度在4-50个字符，注：不含省市区。门店详细地址按规范格式填写地址，以免影响门店搜索及活动报名：例1：道路+门牌号，“人民东路18号”；例2：道路+门牌号+标志性建筑+楼层，“四川北路1552号欢乐广场1楼”
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝帐号
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 门店支持的车型品牌，支付宝车型库品牌编号（系统唯一），品牌编号可以通过调用【查询车型信息接口】alipay.eco.mycar.carmodel.query 获取。
        /// </summary>
        [JsonPropertyName("brand_ids")]
        public List<string> BrandIds { get; set; }

        /// <summary>
        /// 城市编号（国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>）
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店营业结束时间（HH:mm）
        /// </summary>
        [JsonPropertyName("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 门店店长邮箱
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 门店店长移动电话号码；不在客户端展示
        /// </summary>
        [JsonPropertyName("contact_mobile_phone")]
        public string ContactMobilePhone { get; set; }

        /// <summary>
        /// 门店店长姓名
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 区编号（国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>）
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 扩展参数，json格式，可以存放营销信息，以及主营描述等扩展信息
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 行业应用类目编号  15：洗车  16：保养  17：停车  20：4S
        /// </summary>
        [JsonPropertyName("industry_app_category_id")]
        public List<long> IndustryAppCategoryId { get; set; }

        /// <summary>
        /// 行业类目编号（<a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=205&articleId=104497&docType=1">点此查看</a> 非口碑类目 – 爱车）
        /// </summary>
        [JsonPropertyName("industry_category_id")]
        public List<long> IndustryCategoryId { get; set; }

        /// <summary>
        /// 高德地图纬度（经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数准确）
        /// </summary>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 高德地图经度（经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数准确）
        /// </summary>
        [JsonPropertyName("lon")]
        public string Lon { get; set; }

        /// <summary>
        /// 车主平台接口上传主图片地址，通过alipay.eco.mycar.image.upload接口上传。
        /// </summary>
        [JsonPropertyName("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 分支机构编号，商户在车主平台自己创建的分支机构编码
        /// </summary>
        [JsonPropertyName("merchant_branch_id")]
        public long MerchantBranchId { get; set; }

        /// <summary>
        /// 门店营业开始时间（HH:mm）
        /// </summary>
        [JsonPropertyName("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 车主平台接口上传副图片地址，通过alipay.eco.mycar.image.upload接口上传。
        /// </summary>
        [JsonPropertyName("other_images")]
        public List<string> OtherImages { get; set; }

        /// <summary>
        /// 外部门店编号，门店创建时上传的ISV门店唯一标示
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 省编号（国标码，详见国家统计局数据 <a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/AreaCodeList.zip">点此下载</a>）
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 分店名称，比如：万塘路店，与主门店名合并在客户端显示为：爱特堡(益乐路店)
        /// </summary>
        [JsonPropertyName("shop_branch_name")]
        public string ShopBranchName { get; set; }

        /// <summary>
        /// 车主平台门店编号
        /// </summary>
        [JsonPropertyName("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 主门店名，比如：爱特堡；主店名里不要包含分店名，如“益乐路店”。主店名长度不能超过20个字符
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店电话号码；支持座机和手机，只支持数字和+-号，在客户端对用户展现。
        /// </summary>
        [JsonPropertyName("shop_tel")]
        public string ShopTel { get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店状态（0：下线；1：上线）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
