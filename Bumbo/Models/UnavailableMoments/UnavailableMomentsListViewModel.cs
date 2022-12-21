using System.ComponentModel.DataAnnotations;

namespace Bumbo.Models.UnavailableMoments;

public class UnavailableMomentsListViewModel
{
    public List<UnavailableMomentsViewModel> UnavailableMoments;

    public UnavailableMomentsListViewModel(List<UnavailableMomentsViewModel> unavailableMoments)
    {
        UnavailableMoments = unavailableMoments;
        CopyFrom = DateTime.Now.Date;
        CopyTo = DateTime.Now.Date.AddDays(1);
    }

    public UnavailableMomentsListViewModel()
    {
        UnavailableMoments = new List<UnavailableMomentsViewModel>();
        CopyFrom = DateTime.Now.Date;
        CopyTo = DateTime.Now.Date.AddDays(1);
    }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    [DataType(DataType.Date)]
    public DateTime CopyFrom { get; set; }

    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
    [DataType(DataType.Date)]
    public DateTime CopyTo { get; set; }
}