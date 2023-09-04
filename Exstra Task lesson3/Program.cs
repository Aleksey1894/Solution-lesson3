// See https://aka.ms/new-console-template for more information

DateTime now = DateTime.Now;

Console.WriteLine(now.ToString());
Console.WriteLine("\n");

DateTime newYearDate = new DateTime(2024, 01, 01);

DateTime lastYearDate = new DateTime(2022, 12, 31);

TimeSpan left = newYearDate - now;

Console.WriteLine(left.Days + " days left to New Year\n");

TimeSpan passed = now - lastYearDate;

Console.WriteLine(passed.Days + " days passed from New Year");

Console.ReadKey();

