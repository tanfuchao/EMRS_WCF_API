using SqlSugar;

/**
 * 字段中文名称	    字段名	                类型	长度	说明
病人标识号	        PATIENT_ID	            C	10	病人唯一标识号，可以由用户赋予具体的含义，如：病案号，门诊号等
住院号	            INP_NO	                C	10	可选的病人标识，可为空
姓名	            NAME	                C	20	病人姓名
姓名拼音	        NAME_PHONETIC	        C	16	病人姓名拼音，大写，字间用一个空格分隔，超长截断
性别	            SEX	                    C	4	男、女、未知，本系统定义，见1.1性别字典
出生日期	        DATE_OF_BIRTH	        D		
出生地	            BIRTH_PLACE	            C	6	指定省市县，使用代码，见2.2行政区字典
国籍	            CITIZENSHIP	            C	2	使用国家代码，见2.1国家及地区字典
民族	            NATION	                C	10	民族规范名称，见1.3民族字典
身份证号	        ID_NO	                C	18	
身份	            IDENTITY	            C	10	由身份登记子系统生成，住院登记子系统在办理入院时更新。使用规范名称，由用户定义，见1.6身份字典
费别	            CHARGE_TYPE	            C	8	由身份登记子系统生成，住院登记子系统在办理入院时更新。使用规范名称，由用户定义，见1.9费别字典
合同单位	        UNIT_IN_CONTRACT	    C	11	如果病人所在单位为本医院的合同单位或体系单位，则使用代码，否则为空。由身份登记子系统生成，住院登记子系统在办理入院时更新。代码由用户定义，见2.4合同单位记录
通信地址	        MAILING_ADDRESS	        C	40	指永久通信地址
邮政编码	        ZIP_CODE	            C	6	对应通信地址的邮政编码
家庭电话号码	    PHONE_NUMBER_HOME	    C	16	
单位电话号码	    PHONE_NUMBER_BUSINESS	C	16	
联系人姓名	        NEXT_OF_KIN	            C	8	病人的亲属姓名
与联系人关系	    RELATIONSHIP	        C	2	夫妻、父子等，使用代码，见1.19社会关系字典
联系人地址	        NEXT_OF_KIN_ADDR	    C	40	
联系人邮政编码	    NEXT_OF_KIN_ZIP_CODE	C	6	
联系人电话号码	    NEXT_OF_KIN_PHONE	    C	16	
上次就诊日期	    LAST_VISIT_DATE	        D	7	由挂号与预约子系统根据就诊记录填写
重要人物标志	    VIP_INDICATOR	        N	1	1-VIP 0-非VIP
建卡日期	        CREATE_DATE	            D	7	
操作员	            OPERATOR	            C	8	最后修改本记录的操作员姓名
医疗体系病人标志	SERVICE_AGENCY	        C	40	
**/

namespace EMRS.Domain
{
    public class PAT_MASTER_INDEX
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string PATIENT_ID { get; set; }
        public string INP_NO { get; set; }
        public string NAME { get; set; }
        public string NAME_PHONETIC { get; set; }
        public string IDENTITY { get; set; }
        public string CHARGE_TYPE { get; set; }
        public string UNIT_IN_CONTRACT { get; set; }

    }
}
