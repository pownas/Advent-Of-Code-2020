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
    
    validated += passport.ContainsKey("pid") ? 1 : 0; //Checking if passport.ContainsKey("keyName") , if true = 1 , else 0
    validated += passport.ContainsKey("byr") ? 1 : 0;
    validated += passport.ContainsKey("iyr") ? 1 : 0;
    validated += passport.ContainsKey("eyr") ? 1 : 0;
    validated += passport.ContainsKey("hgt") ? 1 : 0;
    validated += passport.ContainsKey("hcl") ? 1 : 0;
    validated += passport.ContainsKey("ecl") ? 1 : 0;

    if (validated >= 7) //If all 7 are true, do another check with function IsPartTwoValid, and pass in a passport that passed validation in part1
    {
        if (IsPassportValueValid(passport)) //If all requred fields are OK, then check if the Data (Value) is valid on the passport
        {
            validNumberOfPassports++; //add +1 to answer (valid passport)
            Console.Write("\n valid - "); //print valid
        }
        else
            Console.Write("\n invalid - ");
    }
    else
        Console.Write("\n invalid - ");


    foreach (var keyValue in passport)
        Console.Write(keyValue.Key + ":" + keyValue.Value + "    ");
}
Console.WriteLine("\n\nTotal number of passports: " + passportList.Count);
Console.WriteLine("\nANSWER - Number of valid passwords: " + validNumberOfPassports);

bool IsPassportValueValid(Dictionary<string, string> passport)
{
    var eyeColors = new[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };

    return IsIntBetween(passport["byr"], 1920, 2002)
           && IsIntBetween(passport["iyr"], 2010, 2020)
           && IsIntBetween(passport["eyr"], 2020, 2030)
           && Regex.IsMatch(passport["hcl"], "^#[a-f0-9]{6}$")
           && Regex.IsMatch(passport["pid"], "^[0-9]{9}$")
           && eyeColors.Contains(passport["ecl"])
           && IsHeightValid(passport["hgt"]);
}

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