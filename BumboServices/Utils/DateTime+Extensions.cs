namespace BumboServices.Utils;

public static class DateTime_Extensions
{
    public static int Age(this DateOnly date) {  
        int age = 0;  
        age = DateTime.Now.Year - date.Year;  
        if (DateTime.Now.DayOfYear < date.DayOfYear)  
            age = age - 1;  
  
        return age;  
    } 
}