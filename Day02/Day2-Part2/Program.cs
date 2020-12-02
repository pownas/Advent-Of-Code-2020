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

    string firstNum = subSplitt[0];
    string secondNum = subSplitt[1];
    string searchCharacter = splittedLine[1].Replace(":", "");
    string strPassword = splittedLine[2];

    //string firstNum = "8";
    //string secondNum = "11";
    //string searchCharacter = "z";
    //string strPassword = "zzzzzzzpzzlzzzzszzzz";

    if (validatePasswordPolicy(int.Parse(firstNum), int.Parse(secondNum), char.Parse(searchCharacter), strPassword))
    {
        Console.Write("true - ");
        numberOfValidPass++;
    }
    else
    {
        Console.Write("false - ");
    }

    Console.WriteLine("First position: " + firstNum + ", Second position: " + secondNum + ", Char: " + searchCharacter + ", Password: " + strPassword);

}

Console.WriteLine("\nNumber of valid passwords: " + numberOfValidPass);


bool validatePasswordPolicy(int first, int second, char character, string password)
{
    char[] charPassword = password.ToCharArray();
    bool checkFirst = false;
    bool checkSecond = false;
    bool returnValue;

    for (int i = 0; i < charPassword.Length; i++)
    {
        if (charPassword[i] == character && first-1 == i)
        {
            checkFirst = true;
        }
        if (charPassword[i] == character && second - 1 == i)
        {
            checkFirst = true;
        }
    }


    if (checkFirst is true && checkSecond is true || checkFirst is false && checkSecond is false)
    {
        returnValue = false;
    }
    else
    {
        returnValue = true;
    }

    return returnValue;
}