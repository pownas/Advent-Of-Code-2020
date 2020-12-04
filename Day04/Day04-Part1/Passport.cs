//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Passport
//{

//    /// <summary>
//    ///     pid (Passport ID) , example> pid:860033327
//    /// </summary>
//    /// <example>pid:860033327</example>
//    public int PassID { get; set; }

//    /// <summary>
//    ///     cid (Country ID) , example> cid:147
//    /// </summary>
//    /// <example>cid:147</example>
//    public int CountryID { get; set; }

//    /// <summary>
//    ///     byr (Birth Year) , example> byr:1937
//    /// </summary>
//    /// <example>byr:1937</example>
//    public int BirthYear { get; set; }

//    /// <summary>
//    ///     iyr (Issue Year) , example> iyr:2017
//    /// </summary>
//    /// <example>iyr:2017</example>
//    public int IssuedYear { get; set; }

//    /// <summary>
//    ///     eyr (Expiration Year) , example> eyr:2020
//    /// </summary>
//    /// <example>eyr:2020</example>
//    /// <param name="eyr">2020</param>
//    public int ExpYear { get; set; }

//    /// <summary>
//    ///     hgt (Height) - in CM , example> hgt:183cm / hgt:59in
//    /// </summary>
//    /// <example>hgt:183cm / hgt:59in</example>
//    /// <param name="hgt">183cm / 59in</param>
//    public int Height { get; set; }

//    /// <summary>
//    ///     hcl (Hair Color) , example> hcl:#fffffd
//    /// </summary>
//    /// <example>hcl:#fffffd</example>
//    public string HairColor { get; set; }

//    /// <summary>
//    ///     ecl (Eye Color) , example> ecl:gry
//    /// </summary>
//    /// <example>ecl:gry</example>
//    public string EyeColor { get; set; }

//    public Passport()
//    {

//    }

//    /// <summary>
//    ///     A passport
//    /// </summary>
//    public Passport(int passID, int countryID, int birthYear, int issuedYear, int expYear, int height, string hairColor, string eyeColor)
//    {
//        PassID = passID;
//        CountryID = countryID;
//        BirthYear = birthYear;
//        IssuedYear = issuedYear;
//        ExpYear = expYear;
//        Height = height;
//        HairColor = hairColor;
//        EyeColor = eyeColor;
//    }
//}
