using Bumbo.Models.RosterManager;
using System.ComponentModel;
using System.Globalization;
namespace Bumbo.Models.UnavailableMoments
{
    public class UnavailableMomentsListViewModel
    {
        public int PrognosisDayId { get; set; }
        public DateTime Date { get; set; }

        [DisplayName("Kassa Afdeling")]
        public double CassierePrognose { get; set; }
        [DisplayName("Vers Afdeling")]
        public double FreshPrognose { get; set; }
        [DisplayName("VakkenVullers Afdeling")]
        public double StockersPrognose { get; set; }

        public List<EmployeeRosterViewModel> Employees { get; set; }

        public UnavailableMomentsListViewModel()
        {
            Employees = new List<EmployeeRosterViewModel>();
        }

        public int GetWeekNumber(DateTime date)
        {
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
