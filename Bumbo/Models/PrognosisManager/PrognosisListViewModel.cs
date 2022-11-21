using BumboRepositories.Utils;

namespace Bumbo.Models.PrognosisManager
{
    public class PrognosisListViewModel
    {
        public List<PrognosisViewModel> PrognosisList { get; set; }

 
        public int CopyFromWeekNumber { get; set; }
        public int CopyToWeekNumber { get; set; }

        public int CopyFromYear { get; set; }
        public int CopyToYear { get; set; }


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

            string headerString = "Week "
                    + firstDate.GetWeekNumber()
                    + " | "
                    + firstDate.Day
                    + " "
                    + firstDate.ToString("MMMM")
                    + "   -  "
                    + lastDate.Day
                    + " "
                    + lastDate.ToString("MMMM")
                    + "  "
                    + lastDate.Year;
            return headerString;
        }
    }
}
