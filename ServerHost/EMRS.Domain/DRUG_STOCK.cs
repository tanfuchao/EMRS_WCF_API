using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRS.Domain
{
    /**
     * 库存管理单位	    STORAGE	                C	8	    库房代码，见库存单位字典
     * 药品代码	        DRUG_CODE	            C	20	    由药品字典定义的代码
     * 规格	            DRUG_SPEC	            C	20	    由药品字典定义的规格
     * 单位	            UNITS	                C	8	    对应剂型及规格，使用规范名称，见4.32计量单位字典
     * 批号	            BATCH_NO	            C	16	    使用“XX/XX/XXXXXX”
     * 有效期	        EXPIRE_DATE	            D		    药品的有效截止日期
     * 厂家标识	        FIRM_ID	                C	10	    反映生产厂家，见药品生产厂家字典
     * 包装规格	        PACKAGE_SPEC	        C	20	    反映药品含量及包装信息，如0.25g*30
     * 进货价	        PURCHASE_PRICE	        N	10,4	购买价，以包装单位记单价
     * 折扣	            DISCOUNT	            N	5,2	    该药品购入时的折扣率。百分数，只记录数值部分
     * 数量	            QUANTITY	            N	12,2	以包装规格及包装单位所计的现库存数量，每次出库，该数量核减
     * 包装单位	        PACKAGE_UNITS	        C	8	    对应包装规格的计量单位，可使用任一级管理上方便的包装
     * 内含包装1	    SUB_PACKAGE_1	        N	12,2	上述一个包装单位中包含的小包装数量，为空或1表示为无此级包装
     * 内含包装1单位	SUB_PACKAGE_UNITS_1	    C	8	    对应内含包装1的单位
     * 内含包装1规格	SUB_PACKAGE_SPEC_1	    C	20	    对应内含包装1的规格
     * 内含包装2	    SUB_PACKAGE_2	        N	12,2	内含包装1中包含的小包装数量，为空或1表示为无此级包装
     * 内含包装2单位	SUB_PACKAGE_UNITS_2	    C	8	    对应内含包装2的单位
     * 内含包装2规格	SUB_PACKAGE_SPEC_2	    C	20	    对应内含包装2的规格
     * 存放库房	        SUB_STORAGE	            C	8	    一个库存管理单位内的存放库房
     * 货位	            LOCATION	            C	20	    描述存放该批药品的位置，自由描述
     * 入库单号	        DOCUMENT_NO	            C	10	    该药品对应的入库单号，当多次入库的药品合并记录时，该项为空
     * 供应标志	        SUPPLY_INDICATOR	    N	1	    反映该药品当前是否可供使用，0-不可供 1-可供
    **/
    public class DRUG_STOCK
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string STORAGE { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public string DRUG_CODE { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public string DRUG_SPEC { get; set; }
        public string UNITS { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public string BATCH_NO { get; set; }
        public DateTime EXPIRE_DATE { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public string FIRM_ID { get; set; }

        [SugarColumn(IsPrimaryKey = true)]
        public string PACKAGE_SPEC { get; set; }
        public decimal PURCHASE_PRICE { get; set; }
        public decimal? DISCOUNT { get; set; }
        public int QUANTITY { get; set; }
        public string PACKAGE_UNITS { get; set; }
        public decimal? SUB_PACKAGE_1 { get; set; }
        public string SUB_PACKAGE_UNITS_1 { get; set; }
        public string SUB_PACKAGE_SPEC_1 { get; set; }
        public decimal? SUB_PACKAGE_2 { get; set; }
        public string SUB_PACKAGE_UNITS_2 { get; set; }
        public string SUB_PACKAGE_SPEC_2 { get; set; }
        public string SUB_STORAGE { get; set; }
        public string LOCATION { get; set; }
        public string DOCUMENT_NO { get; set; }
        public int SUPPLY_INDICATOR { get; set; }
    }
}
