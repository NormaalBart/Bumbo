using CsvHelper.Configuration.Attributes;

namespace BumboServices.Import;

// Model used by the imported CSV's from Brightspace
public class EmployeeCsvModel
{
    [Name("BID")] public string Id { get; set; }

    [Name("Vn")] public string FirstName { get; set; }

    [Name("Tv")] public string? Preposition { get; set; }

    [Name("An")] public string LastName { get; set; }

    [Name("Geboortedatum")] public DateOnly Birthdate { get; set; }

    [Name("Postcode")] public string Postalcode { get; set; }

    [Name("Huisnummer")] public string Housenumber { get; set; }

    [Name("In dienst")] public DateOnly EmployeeSince { get; set; }

    [Name("Email")] public string Email { get; set; }

    [Name("Functie")] public string Function { get; set; }
}