namespace BumboServices.Roster;

public enum RosterCreationResponse
{
    Success,
    Incomplete,
    NoEmployees,
    NoBranch,
    ClosedOnDay,
    AlreadyReachedPrognosis,
    CaoViolationsFound,
    NoPrognoseFound
}