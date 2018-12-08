//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
namespace bookyourdoctor
{
    
    
    public partial class doctor_scedule
    {
        private FINALSCRIPTTEntities db = new FINALSCRIPTTEntities();

        [Required]
        [Display(Name = "Clinic Start Time")]
        [DataType(DataType.Time)]
        public System.DateTime clinic_start_time { get; set; }

        [Required]
        [Display(Name = "Hospital Start Time")]
        [DataType(DataType.Time)]
        public System.DateTime hospital_start_time { get; set; }

        [Required]
        [Display(Name = "Clinic End Time")]
        [DataType(DataType.Time)]
        public System.DateTime clinic_end_time { get; set; }

        [Required]
        [Display(Name = "Hospital End Time")]
        [DataType(DataType.Time)]
        public System.DateTime hospital_end_time { get; set; }


        public string is_avalible { get; set; }

        [Required]
        [Display(Name = "Clinic Day")]
        public string Clinic_day { get; set; }

        [Required]
        [Display(Name = "Hospital Day")]
        public string hospial_day { get; set; }

        [Required]
        [Display(Name = "Doctor Id")]
        public string doctor_id { get; set; }

        public static IEnumerable<SelectListItem> GetDay()
        {
            IList<SelectListItem> items = new List<SelectListItem>
        {

            new SelectListItem { Text="Monday",Value="Monday"},
            new SelectListItem { Text="Tuesday",Value="Tuesday"},
            new SelectListItem { Text="Wednesday",Value="Wednesday"},
            new SelectListItem { Text="Thursday",Value="Thursday"},
            new SelectListItem { Text="Friday",Value="Friday"},
            new SelectListItem { Text="Saturday",Value="Saturday"},
            new SelectListItem { Text="Sunday",Value="Sunday"},

        };
            return items;
        }


    }
}
