using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace BumboServices.Import;

public class DateOnlyTypeConverter : TypeConverter
{
    public override object? ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
    {
        return DateOnly.FromDateTime(DateTime.ParseExact(text, "dd/mm/yyyy", CultureInfo.InvariantCulture));
    }
}