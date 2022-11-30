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

            if (index + 1 < Days.Count)
            {
                OverviewItem day = Days[index];

                return Days[index];
            }
            return null;
        }

        // returns total number of items that are not sufficiently rostered.
        public int GetTotalNumberOfItemsNotSufficientlyRostered()
        {
            int total = 0;
            foreach (OverviewItem day in Days)
            {
                if (!day.IsSufficientlyRostered() && day.RosteredHours != 0)
                {
                    total++;
                }
            }
            return total;
        }

        // returns total number of items that are without roster
        public int GetTotalNumberOfItemsWithoutRoster()
        {
            int total = 0;
            foreach (OverviewItem day in Days)
            {
                if (day.RosteredHours == 0)
                {
                    total++;
                }
            }
            return total;
        }

        // returns total number of items that sufficiently roster
        public int GetTotalNumberOfItemsSufficientlyRostered()
        {
            int total = 0;
            foreach (OverviewItem day in Days)
            {
                if (day.IsSufficientlyRostered())
                {
                    total++;
                }
            }
            return total;
        }

    }
}
