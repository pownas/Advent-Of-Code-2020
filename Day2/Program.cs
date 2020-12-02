using System;
using System.Collections.Generic;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData();

int numberOfValidPass = 0;

string[] splittedLine;
string[] subSplitt;

string minChar;
string maxChar;
string searchCharacter;
string strPassword;

foreach (var line in dataList)
{
    splittedLine = line.Split(" ");
    subSplitt = splittedLine[0].Split("-");

    minChar = subSplitt[0];
    maxChar = subSplitt[1];
    searchCharacter = splittedLine[1].Replace(":", "");
    strPassword = splittedLine[2];


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