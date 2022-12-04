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
        [Display(Name = "In afwachting")]
        Pending,
        [Display(Name = "Goedgekeurd")]
        Approved,
        [Display(Name = "Afgekeurd")]
        Rejected


    }
}
