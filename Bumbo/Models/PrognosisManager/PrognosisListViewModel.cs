using BumboData.Models;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace Bumbo.Models.PrognosisManager
{
    public class PrognosisListViewModel
    {
        public List<PrognosisViewModel> PrognosisList { get; set; }


        // displays the week number + the start date - end date of the list
        public string DisplayListHeader
        {
            get { return GenerateHeaderString(); }
        }

        public PrognosisListViewModel()
        {
            PrognosisList = new List<PrognosisViewModel>();
        }



        private string GenerateHeaderString()
        {
            // Generates the string that is used in the prognosislist view, which has the week number and the first date to last date in the view. 
            // This will look something like this: 
            // Week 45 | 8 november - 12 november 
            if (PrognosisList == null || PrognosisList.Count == 0)
            {
                return "Week 0 | 0 november - 0 november";
            }
            DateTime firstDate = PrognosisList.OrderBy(p => p.Date).FirstOrDefault().Date;
            DateTime lastDate = PrognosisList.OrderByDescending(p => p.Date).FirstOrDefault().Date;

            string result = "Week "
                    + System.Globalization.CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(firstDate, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                    + " | "
                    + firstDate.Day
                    + " "
                    + firstDate.ToString("MMMM")
                    + "   -  "
                    + lastDate.Day
                    + " "
                    + lastDate.ToString("MMMM");
            return result;
        }
    }
}
