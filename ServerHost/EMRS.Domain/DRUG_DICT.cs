using System;

namespace EMRS.Domain
{
    /**
     * 药品代码	        DRUG_CODE	        C	10	药品名（含剂型）的唯一标识，与药品规格一起构成一种药品（含规格）的标识
     * 药品名称	        DRUG_NAME	        C	40	药品的标准名称
     * 规格	            DRUG_SPEC	        C	20	反映药品的含量信息，如25mg
     * 单位	            UNITS	            C	8	对应剂型及规格的最小单位，如片、支等，使用规范名称，见4.32计量单位字典
     * 剂型	            DRUG_FORM	        C	10	如针剂、片剂等，使用规范描述，见剂型字典
     * 毒理分类	        TOXI_PROPERTY	    C	10	按药品的毒理分类，如普通、毒麻、精神等，使用规范名称，本系统定义，见毒理字典
     * 最小单位剂量	    DOSE_PER_UNIT	    N	8,3	每一最小不可分包装单位所含剂量，如每片、每支的剂量
     * 剂量单位	        DOSE_UNITS	        C	8	剂量的单位，如mg、ml等
     * 药品类别标志	    DRUG_INDICATOR	    N	1	反映是否药品及何类药品：1-西药2-中草药 3-中成药 5-辅料 6-试剂 9-其它
     * 输入码	        INPUT_CODE	        C	8	
     * OTC类型	        OTC	                C	10	
     * 限制等级	        LIMIT_CLASS	        C	4	医生开药限制等级,特级，一级，二级，三级，四级
     * 停药标志	        Stop_flag	        c	1	1-停药
     * 录入日期	        ENTERED_DATETIME 	D	
     * 途径             ADMINISTRATION      C
     * 备注             NOTES               C
     */
    public class DRUG_DICT
    {
        public string DRUG_CODE { get; set; }
        public string DRUG_NAME { get; set; }
        public string DRUG_SPEC { get; set; }
        public string UNITS { get; set; }
        public string DRUG_FORM { get; set; }
        public string TOXI_PROPERTY { get; set; }
        public decimal DOSE_PER_UNIT { get; set; }
        public string DOSE_UNITS { get; set; }
        public int DRUG_INDICATOR { get; set; }
        public string INPUT_CODE { get; set; }
        public string LIMIT_CLASS { get; set; }
        public string STOP_FLAG { get; set; }
        public DateTime ENTERED_DATETIME { get; set; }

        public string ADMINISTRATION { get; set; }
        public string NOTES { get; set; }

    }
}
