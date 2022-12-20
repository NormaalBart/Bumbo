using Microsoft.VisualBasic.CompilerServices;

namespace BumboServices.Roster;

public enum RosterCreationResponse
{
    Succes,
    Incomplete,
    NoEmployees,
    NoBranch,
    ClosedOnDay,
    AlreadyReachedPrognosis,
    CaoViolationsFound,
    NoPrognoseFound
}