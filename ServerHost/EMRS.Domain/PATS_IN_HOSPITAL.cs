using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/**
 * 字段中文名称	        字段名	                类型	长度	说明
病人标识号	            PATIENT_ID	            C	10	非空
病人本次住院标识	    VISIT_ID	            N	2	非空
所在病房代码	        WARD_CODE	            C	8	病人住院登记后，将该字段置为空，在入科时，将该字段置为本病房代码，转科时，由转出科室将该代码置为空
所在科室代码	        DEPT_CODE	            C	8	病人住院所属科室的代码。用于区分一个病房包含多个科室的床位的情况。病人住院登记后，将该字段置为空，在入科分配床位时，根据床位属性将该字段置为所在科室代码，转科时，由转出科室将该代码置为空
床号	                BED_NO	                N	3	当入院处理时可为空
入院日期及时间	        ADMISSION_DATE_TIME	    D	7	由住院登记系统填入
入科日期及时间	        ADM_WARD_DATE_TIME	    D	7	指病人入当前所在病房的日期及时间，由病房入出转子系统填入，转科时置为空
主要诊断	            DIAGNOSIS	            C	80	截止当前确定的主要诊断，正文描述。初始时，由住院登记子系统录入
病情状态	            PATIENT_CONDITION	    C	1	病人危重情况，使用代码，见1.13病情状态字典
护理等级	            NURSING_CLASS	        C	1	使用代码，见4.15护理等级字典
经治医生	            DOCTOR_IN_CHARGE	    C	8	当前的经治医生姓名
手术日期	            OPERATING_DATE	        D		已进行最后一次手术的日期
计价截止日期及时间	    BILLING_DATE_TIME	    D		最近一次计价的日期，在该日期之间已发生的各种医疗费用已记帐
预交金余额	            PREPAYMENTS	            N	10,2	扣除已结算费用后病人的预交金金额（未扣除未结算部分）
累计未结费用	        TOTAL_COSTS	            N	10,2	病人未结算部分的费用。如果病人未进行中途结算，则为本次住院总费用。按正常价表计算得到
优惠后未结费用	        TOTAL_CHARGES	        N	10,2	按病人费别优惠后累计未结费用
经济担保人	            GUARANTOR	            C	8	在住院登记时指定本病人的经济担保人
经济担保人所在单位	    GUARANTOR_ORG	        C	40	正文描述
经济担保人联系电话	    GUARANTOR_PHONE_NUM	    C	16	
上次划价检查日期	    BILL_CHECKED_DATE_TIME	D		最近一次划价审核的日期，每次由住院收费程序人工审核后更新
出院结算标记	        SETTLED_INDICATOR	    N	1	0-未进行出院结算 1-已进行出院结算 入院时，由住院登记子系统将该字段置为0；出院结算时，由住院收费子系统将该字段置为1。
借床床位号	            LEND_BED_NO	            N	3	
床位科室代码	        BED_DEPT_CODE	        C	8	
床位护理单元	        BED_WARD_CODE	        C	8	
借床科室	            DEPT_CODE_LEND	        C	8	
借床标志	            LEND_INDICATOR	        N	1	
是否新生儿	            IS_NEWBORN	            N	1	
**/
namespace EMRS.Domain
{
    public class PATS_IN_HOSPITAL
    {
        public string PATIENT_ID { get; set; }
        public int VISIT_ID { get; set; }
        public string DEPT_CODE { get; set; }
        public string DOCTOR_IN_CHARGE { get; set; }
        public decimal PREPAYMENTS { get; set; }
        public decimal TOTAL_CHARGES { get; set; }

    }
}
