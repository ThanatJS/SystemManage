//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemManage.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubTask
    {
        public string SubID { get; set; }
        public string SubName { get; set; }
        public byte SubStatus { get; set; }
        public double SubPercent { get; set; }
        public string SubDescriptionDev { get; set; }
        public string SubDevID { get; set; }
        public System.DateTime SubDevSend { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public string TaskID { get; set; }
    }
}
