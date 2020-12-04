using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<Dictionary<string, string>> passportList = inputFile.ReadKeyValue(@"Day04-input.txt", " ", ":");

int validNumberOfPassports = 0;

foreach (var passport in passportList)
{
    int validated = 0;
    validated += passport.ContainsKey("pid") ? 1 : 0;
    validated += passport.ContainsKey("byr") ? 1 : 0;
    validated += passport.ContainsKey("iyr") ? 1 : 0;
    validated += passport.ContainsKey("eyr") ? 1 : 0;
    validated += passport.ContainsKey("hgt") ? 1 : 0;
    validated += passport.ContainsKey("hcl") ? 1 : 0;
    validated += passport.ContainsKey("ecl") ? 1 : 0;
    if (validated >= 7)
    {
        validNumberOfPassports++;
        Console.Write("\n valid - ");
    }
    else
        Console.Write("\n invalid - ");

    foreach (var keyValue in passport)
        Console.Write(keyValue.Key + ":" + keyValue.Value + "    ");
}
Console.WriteLine("\n\nTotal number of passports: " + passportList.Count);

Console.WriteLine("\nANSWER - Number of valid passwords: " + validNumberOfPassports);