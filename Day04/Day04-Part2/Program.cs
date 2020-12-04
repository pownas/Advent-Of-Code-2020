using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
        if (passport.ContainsKey("pid"))
            validated += IsPartTwoValid(passport) ? 1 : 0;
        if (passport.ContainsKey("byr"))
            validated += IsPartTwoValid(passport) ? 1 : 0;
        if (passport.ContainsKey("iyr"))
            validated += IsPartTwoValid(passport) ? 1 : 0;
        if (passport.ContainsKey("eyr"))
            validated += IsPartTwoValid(passport) ? 1 : 0;
        if (passport.ContainsKey("hgt"))
            validated += IsPartTwoValid(passport) ? 1 : 0;
        if (passport.ContainsKey("hcl"))
            validated += IsPartTwoValid(passport) ? 1 : 0;
        if (passport.ContainsKey("ecl"))
            validated += IsPartTwoValid(passport) ? 1 : 0;

        if (validated >= 14)
        {
            validNumberOfPassports++;
            Console.Write("\n valid - ");
        }
        else
            Console.Write("\n invalid - ");
    }
    else
        Console.Write("\n invalid - ");

    foreach (var keyValue in passport)
        Console.Write(keyValue.Key + ":" + keyValue.Value + "    ");

}
Console.WriteLine("\nANSWER - Number of valid passwords: " + validNumberOfPassports);


bool IsPartTwoValid(Dictionary<string, string> dictionary)
{
    var eyeColors = new[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

    return IsIntBetween(dictionary["byr"], 1920, 2002)
           && IsIntBetween(dictionary["iyr"], 2010, 2020)
           && IsIntBetween(dictionary["eyr"], 2020, 2030)
           && Regex.IsMatch(dictionary["hcl"], "^#[a-f0-9]{6}$")
           && Regex.IsMatch(dictionary["pid"], "^[0-9]{9}$")
           && eyeColors.Contains(dictionary["ecl"])
           && IsHeightValid(dictionary["hgt"]);
}
Console.WriteLine("\n\nTotal number of passports: " + passportList.Count);

bool IsHeightValid(string height)
{
    if (height.Contains("cm"))
        return IsIntBetween(height.Replace("cm", ""), 150, 193);
    if (height.Contains("in"))
        return IsIntBetween(height.Replace("in", ""), 59, 76);
    return false;
}

bool IsIntBetween(string str, int min, int max)
{
    return int.TryParse(str, out var val) && val >= min && val <= max;
}