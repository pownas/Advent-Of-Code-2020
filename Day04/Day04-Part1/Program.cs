using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day03-input.txt"); //Read data from: "../../AdventOfCode2020/Data/{dataInputFile}"

//Examples:
Passport pass1 = new Passport(860033327, 147, 1937, 2017, 2020, 183, "CM", "#fffffd", "gry");
Passport pass2 = new Passport(028048884, 350, 1929, 2013, 2023, 0, "NONE", "#cfa07d", "amb");
Passport pass3 = new Passport(760753108, 147, 1931, 2013, 2024, 179, "CM", "#ae17e1", "brn");
Passport pass4 = new Passport(166559648, 0, 1937, 2011, 2025, 59, "IN", "#cfa07d", "brn");




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
public record Passport(int pid, int cid, int byr, int iyr, int eyr, int hgt, string hgtINCM, string hcl, string ecl);