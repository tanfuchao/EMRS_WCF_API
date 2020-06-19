namespace EMRS.Domain
{
    /**
     *  药品代码	DRUG_CODE	    C	10	由药品字典定义的代码
     *  药品名称	DRUG_NAME	    C	40	
     *  正名标志	STD_INDICATOR	N	1	0-别名 1-正名
     *  输入码	    INPUT_CODE	    C	8	
**/
    public class DRUG_NAME_DICT
    {
        public string DRUG_CODE { get; set; }
        public string DRUG_NAME { get; set; }
        public int STD_INDICATOR { get; set; }
        public string INPUT_CODE { get; set; }
    }
}
