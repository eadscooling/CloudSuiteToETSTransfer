namespace CloudSuiteToETSTransfer.Classes
{
    public class MasterScheduleClass
    {
        public string CoNum { get; set; }
        public string CoLineItem { get; set; }
        public DateTime? CoLineDueDate { get; set; }
        public string? ItemDescription { get; set; }
        public string? CustItem { get; set; }
        public string? CustName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ue_uf_EDS_RoutingID { get; set; }
        public string CoStat { get; set; }

    }
}
