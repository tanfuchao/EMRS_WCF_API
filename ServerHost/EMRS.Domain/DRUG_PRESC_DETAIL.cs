using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 字段中文名称	        字段名	        类型	长度	说明
处方日期	            PRESC_DATE	    D		与处方序号一起构成一张处方的唯一标识
处方号	                PRESC_NO	    N	5	
项目序号	            ITEM_NO	        N	2	按处方标识分组排序
药品代码	            DRUG_CODE	    C	20	由用户定义，见5.2药品字典
药品规格	            DRUG_SPEC	    C	20	由药品字典定义的规格
药品名称	            DRUG_NAME	    C	100	
厂商标识	            FIRM_ID	        C	10	反映生产厂家，见药品生产厂家字典
包装规格	            PACKAGE_SPEC	C	20	反映药品含量及包装信息，如0.25g*30
单位	                PACKAGE_UNITS	C	8	如瓶、包等，使用规范描述，见4.3.2计量单位字典
数量	                QUANTITY	    N	6,2	以分装为单位的数量，如2包
费用	                COSTS	        N	10,4	按标准价格计算得到的费用
实付费用	            PAYMENTS	    N	10,4	考虑费别等因素后的实际支付费用
医嘱序号	            Order_no	    n	4	
医嘱子序号	            Order_sub_no	n	2	
用法	                administration	c	40	
退药标志	            flag	        n	1	1,null-正常 2-退药
**/

namespace EMRS.Domain
{
    public class DRUG_PRESC_DETAIL
    {
        [SugarColumn(IsPrimaryKey =true)]
        public string PACKAGE_SPEC { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public int PRESC_NO { get; set; }
        
        
        public string DRUG_NAME { get; set; }

        public int QUANTITY { get; set; }
        public string FIRM_ID { get; set; }
        public DateTime PRESC_DATE { get; set; }

        public int ITEM_NO { get; set; }
        public string DRUG_CODE { get; set; }
        public string PACKAGE_UNITS { get; set; }

        public decimal COSTS { get; set; }
        public decimal PAYMENTS { get; set; }

        public string DRUG_SPEC { get; set; }




    }
}
