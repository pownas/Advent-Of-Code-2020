using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day03-input.txt"); //Read data from: "../../AdventOfCode2020/Data/{dataInputFile}"

Passport pass = new Passport();


/// <summary>
///     pid(Passport ID), 
///     cid(Country ID), 
///     byr(Birth Year), 
///     iyr(Issue Year), 
///     eyr(Expiration Year), 
///     hgt(Height), 
///     hcl(Hair Color), 
///     ecl(Eye Color)
/// </summary>
public record Passport(int PassID, int CountryID, int BirthYear, int IssuedYear, int ExpYear, int Height, string HairColor, string EyeColor);