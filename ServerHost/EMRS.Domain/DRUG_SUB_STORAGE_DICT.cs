namespace EMRS.Domain
{
    /**
     *  字段中文名	        字段名	            类型	长度	说明
        库存单位代码	    STORAGE_CODE	    C	8	唯一标识一个库存单位，可使用单位代码
        库房	            SUB_STORAGE	        C	8	
        入库单号前缀	    IMPORT_NO_PREFIX	C	6	此前缀与入库单流水号一起构成入库单号
        入库单可用流水号	IMPORT_NO_AVA	    N	4	当前可用流水号
        出库单号前缀	    EXPORT_NO_PREFIX	C	6	此前缀与出库单流水号一起构成出库单号
        出库单可用流水号	EXPORT_NO_AVA	    N	4	当前可用流水号
*/
    public class DRUG_SUB_STORAGE_DICT
    {
        public string STORAGE_CODE { get; set; }
        public string SUB_STORAGE { get; set; }

        public string IMPORT_NO_PREFIX { get; set; }
        public int IMPORT_NO_AVA { get; set; }
        public string EXPORT_NO_PREFIX { get; set; }
        public int EXPORT_NO_AVA { get; set; }
    }
}
