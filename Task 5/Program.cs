DateTime birthDate = new DateTime(2004, 12, 19); // yyyy, mm, dd
DateTime currentDate = DateTime.Now;

TimeSpan ageSpan = currentDate - birthDate;
int ageYears = (int)(ageSpan.Days / 365.25); // approximate age in years

Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Age: {ageYears} years");

DateTime newDate = birthDate.AddDays(10);
Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");
