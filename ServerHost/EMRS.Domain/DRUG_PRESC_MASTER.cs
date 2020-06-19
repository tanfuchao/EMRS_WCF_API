using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 字段中文名称	        字段名	                    类型	长度	说明
处方日期	            PRESC_DATE	                D		与处方序号一起构成一张处方的唯一标识
处方号	                PRESC_NO	                N	5	在一个日期内唯一
发药药局	            DISPENSARY	                C	8	库存单位代码，见库存单位字典
病人标识号	            PATIENT_ID	                C	10	对有主索引记录的病人使用
姓名	                NAME	                    C	20	
姓名拼音	            NAME_PHONETIC	            C	16	病人姓名拼音，大写，字间用一个空格分隔，超长截断
身份	                IDENTITY	                C	10	使用规范名称，由用户定义，见1.6身份字典
费别	                CHARGE_TYPE	                C	8	使用规范名称，由用户定义，见1.9费别字典
病人合同单位	        UNIT_IN_CONTRACT	        C	11	合同单位代码，见2.4合同单位字典
处方类别	            PRESC_TYPE	                N	1	0=西药 1=中药
处方属性	            PRESC_ATTR	                C	8	反映处方用户定义的属性，如：贵重药、麻醉药等，见处方属性字典
处方来源	            PRESC_SOURCE	            N	1	标识处方是从门诊而来或是从住院而来。0-门诊 1-住院 2-其它
剂数	                REPETITION	                N	2	缺省为1，中药处方时可大于1
费用	                COSTS	                    N	10,4	本处方按标准价格计算得到的总费用
实付费用	            PAYMENTS	                N	10,4	本处方考虑费别等因素后的实际支付费用
开单科室	            ORDERED_BY	                C	8	使用代码，由用户定义，见2.6科室字典
开方医生	            PRESCRIBED_BY	            C	8	开方医生姓名
录方人	                ENTERED_BY	                C	8	录入者姓名
发药人	                DISPENSING_PROVIDER	        C	8	发药者姓名
每剂煎几份	            Count_per_repetition	    N	2	
录入日期	            ENTERED_DATETIME 	        D		
发药日期	            DISPENSING_DATETIME	        D		
备注	                MEMO	                    C	100	
子库房	                SUB_STORAGE	                C	8	
退药标志	            FLAG	                    N	1	1-正常 2-退药 
医生	                DOCTOR_USER	                C	16	
审核	                VERIFY_BY	                C	8	
出院带药标志	        DISCHARGE_TAKING_INDICATOR	N	1	
**/

namespace EMRS.Domain
{
    public class DRUG_PRESC_MASTER
    {
        [SugarColumn(IsPrimaryKey =true)]
        public DateTime PRESC_DATE { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public int PRESC_NO { get; set; }
        public string PATIENT_ID { get; set; }
        public string NAME { get; set; }
        public string NAME_PHONETIC { get; set; }
        public string IDENTITY { get; set; }
        public string CHARGE_TYPE { get; set; }
        public string ORDERED_BY { get; set; }
        public string PRESCRIBED_BY { get; set; }
        public string DISPENSING_PROVIDER { get; set; }
        public string PRESC_ATTR { get; set; }
        public string DISPENSARY { get; set; }
        public int PRESC_SOURCE { get; set; }
        public string UNIT_IN_CONTRACT { get; set; }
        public int PRESC_TYPE { get; set; }
        public int REPETITION { get; set; }
        public decimal COSTS { get; set; }
        public decimal PAYMENTS { get; set; }
        public string ENTERED_BY { get; set; }
    }
}
