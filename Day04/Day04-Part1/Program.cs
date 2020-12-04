using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day03-input.txt"); //Read data from: "../../AdventOfCode2020/Data/{dataInputFile}"

Passport pass = new Passport(860033327, 147, 1937, 2017, 2020, 183);

ecl: gry pid: eyr:  hcl:#fffffd
byr:  iyr:  cid: 147 hgt: cm

    iyr:2013 ecl: amb cid:350 eyr: 2023 pid: 028048884
hcl:#cfa07d byr:1929

hcl:#ae17e1 iyr:2013
eyr: 2024
ecl: brn pid:760753108 byr: 1931
hgt: 179cm

 hcl:#cfa07d eyr:2025 pid:166559648
iyr: 2011 ecl: brn hgt:59in


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
public record Passport(int pid, int cid, int byr, int iyr, int eyr, int hgt, string hcl, string ecl);