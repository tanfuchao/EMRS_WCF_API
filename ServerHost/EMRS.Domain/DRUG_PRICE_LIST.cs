using System;

namespace EMRS.Domain
{
    /**
     *  药品代码	    DRUG_CODE	        C	10	由药品字典定义的代码
     *  规格	        DRUG_SPEC	        C	20	反映药品的含量以及包装
     *  厂家标识	    FIRM_ID 	        C	10	反映生产厂家
     *  单位	        UNITS   	        C	8	对应剂型及规格，使用规范名称，见4.32计量单位字典
     *  市场批发价	    TRADE_PRICE	        N	10,4	药库采购药品时的市场定价
     *  市场零售价	    RETAIL_PRICE	    N	10,4	药品零售时的市场定价
     *  包装数量	    AMOUNT_PER_PACKAGE	N	5	指单位包装中所含最小单位数量。如果已为最小单位，则为1
     *  停止日期	    STOP_DATE	        D		该价格的停止执行日期，执行日期含停止日期当天
     *  最小单位规格	MIN_SPEC	        C	20	反映最小单位药品含量，与药品字典中定义规格同
     *  最小单位	    MIN_UNITS	        C	8	对应最小单位规格的单位，如片
     *  起用日期	    START_DATE	        D		该价格的起用日期，执行日期含起用日期当天
     **/
    public class DRUG_PRICE_LIST
    {
        public string DRUG_CODE { get; set; }
        public string DRUG_SPEC { get; set; }
        public string FIRM_ID { get; set; }
        public string UNITS { get; set; }
        public decimal? TRADE_PRICE { get; set; }
        public decimal? RETAIL_PRICE { get; set; }
        public int? AMOUNT_PER_PACKAGE { get; set; }
        public DateTime? STOP_DATE { get; set; }
        public string MIN_SPEC { get; set; }
        public string MIN_UNITS { get; set; }
        public DateTime START_DATE { get; set; }

    }
}
