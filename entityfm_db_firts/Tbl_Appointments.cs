//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entityfm_db_firts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Appointments
    {
        public int appointmentid { get; set; }
        public Nullable<System.DateTime> appointmentdate { get; set; }
        public string appointmenttime { get; set; }
        public string appointmentbranch { get; set; }
        public int appointmentdoctor { get; set; }
        public Nullable<bool> appointmentstate { get; set; }
        public string patienttc { get; set; }
        public string patientcomplaint { get; set; }
    
        public virtual Tbl_Doctors Tbl_Doctors { get; set; }
    }
}
