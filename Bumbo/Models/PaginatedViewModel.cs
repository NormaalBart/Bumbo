namespace Bumbo.Models;

public abstract class PaginatedViewModel
{
    public int Page { get; set; }

    public int MaxPage { get; set; }
}