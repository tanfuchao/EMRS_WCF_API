using System;

namespace EMRS.Domain
{
    /**
     * 请领库房	        APPLICANT_STORAGE	    C	8	提出申请者库房代码，见库存单位字典
     * 发放库房	        PROVIDE_STORAGE	        C	8	药品发放者库房代码，见库存单位字典
     * 项目序号	        ITEM_NO	                N	4	一个申请者的所有申请药品排序
     * 药品代码	        DRUG_CODE	            C	20	由药品字典定义的代码
     * 规格	            DRUG_SPEC	            C	20	由药品字典定义的规格
     * 包装规格	        PACKAGE_SPEC	        C	20	反映药品含量及包装信息，如0.25g*30
     * 数量	            QUANTITY	            N	12,2	以包装单位所计的数量
     * 包装单位	        PACKAGE_UNITS	        C	8	对应包装规格的单位
     * 申请日期	        ENTER_DATE_TIME	        D		
     * 厂家标识	        FIRM_ID             	C	10	
**/

    public class DRUG_PROVIDE_APPLICATION
    {
        public string APPLICANT_STORAGE { get; set; }
        public string PROVIDE_STORAGE { get; set; }
        public int ITEM_NO { get; set; }
        public string DRUG_CODE { get; set; }
        public string DRUG_SPEC { get; set; }
        public string PACKAGE_SPEC { get; set; }
        public decimal QUANTITY { get; set; }
        public string PACKAGE_UNITS { get; set; }
        public DateTime ENTER_DATE_TIME { get; set; }
        public string FIRM_ID { get; set; }
    }
}
