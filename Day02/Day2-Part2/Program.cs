using AdventOfCode2020;
using System;
using System.Collections.Generic;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day02-input.txt"); //Read data from: "../../AdventOfCode2020/Data/{dataInputFile}"

int numberOfValidPass = 0;

foreach (var line in dataList)
{
    string[] splittedLine = line.Split(" ");
    string[] subSplitt = splittedLine[0].Split("-");

    string minChar = subSplitt[0];
    string maxChar = subSplitt[1];
    string searchCharacter = splittedLine[1].Replace(":", "");
    string strPassword = splittedLine[2];


    if (validatePasswordPolicy(int.Parse(minChar), int.Parse(maxChar), char.Parse(searchCharacter), strPassword))
    {
        Console.Write("true - ");
        numberOfValidPass++;
    }
    else
    {
        Console.Write("false - ");
    }

    Console.WriteLine("Min: " + minChar + ", Max: " + maxChar + ", Char: " + searchCharacter + ", Password: " + strPassword);

}

Console.WriteLine("Number of valid passwords: " + numberOfValidPass);


bool validatePasswordPolicy(int min, int max, char character, string password)
{
    char[] charPassword = password.ToCharArray();
    bool returnValue;
    int numberOfChar = 0;

    for (int i = 0; i < charPassword.Length; i++)
    {
        if (charPassword[i] == character)
        {
            numberOfChar++;
        }
    }

    if (numberOfChar >= min && numberOfChar <= max)
    {
        returnValue = true;
    }
    else
    {
        returnValue = false;
    }

    return returnValue;
}