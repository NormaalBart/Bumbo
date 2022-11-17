using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BumboData.Enums
{
    public enum SortingOption
    {
        [Display(Name = "Naam A-Z")]
        Name_Asc,
        [Display(Name = "Naam Z-A")]
        Name_Desc,
        [Display(Name = "Geboortedatum Nieuwste-Oudste")]
        Birthdate_Desc,
        [Display(Name = "Geboortedatum Oudste-Nieuwste")]
        Birthdate_Asc,
        [Display(Name = "In dienst sinds nieuwste-oudste")]
        EmployeeSince_Desc,
        [Display(Name = "In dienst sinds Oudste-Nieuwste")]
        EmployeeSince_Asc,
        [Display(Name = "Functie Z-A")]
        Function_Desc,
        [Display(Name = "Functie A-Z")]
        Function_Asc

    }

    public static class Extensions
    {
        /// <summary>
        ///     A generic extension method that aids in reflecting 
        ///     and retrieving any attribute that is applied to an `Enum`.
        /// </summary>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
                where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }
    }
}
