using System.Globalization;

public static class Utils
{
    public static DateTime parseDateString(string dateString){
        DateTime parsedDate = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        return parsedDate;
    }
}