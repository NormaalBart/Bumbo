namespace Bumbo.Models.RosterManager
{
    public class OverviewList
    {
        public DateTime Date { get; set; }
        public List<OverviewItem> Days { get; set; }

        public OverviewList()
        {
            Days = new List<OverviewItem>();
        }


        public OverviewItem GetDay(int weekNr, int dayNr)
        {
            int index = (weekNr * 7) + dayNr;

            try
            {
                return Days[index];
            }
            catch (Exception)
            {

                return null;
            }
           

        }
    }
}
