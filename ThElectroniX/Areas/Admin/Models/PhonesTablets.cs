using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThElectroniX_001_WED.Areas.Admin.Models
{
    public class PhonesTablets
    {
        [Key]
        public int PhoneId { get; set; }

        [Display(Name ="Phone Name")]
        public string PhoneName { get; set; }


        [Display(Name = "Phone Short Description")]
        public string PhoneShortDescription { get; set; }


        [Display(Name = "Phone Long Description")]
        public string PhoneLongDescription { get; set; }


        [Display(Name = "Upload Phone Image")]
        public string PhoneImageUrl { get; set; }


        [Display(Name = "Phone Price")]
        public virtual Decimal PhonePriceID { get; set; }
        public ICollection<Prices> Prices { get; set; }
    }
}
