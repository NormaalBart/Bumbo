using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BumboData.Enums
{

    public enum ReviewStatus
    {
        [Display(Name = "Goedgekeurd")]
        Approved = 1,
        [Display(Name = "In afwachting")]
        Pending = 2,
        [Display(Name = "Afgekeurd")]
        Rejected = 3
    }
}
