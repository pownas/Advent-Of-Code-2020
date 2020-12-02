using System;
using System.Collections.Generic;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData();

int numberOfValidPass = 0;

string[] splittedLine;
string[] subSplitt;

string searchStart;
string searchEnd;
string searchCharacter;
string searchPassword;

foreach (var line in dataList)
{
    splittedLine = line.Split(" ");
    subSplitt = splittedLine[0].Split("-");

    searchStart = subSplitt[0];
    searchEnd = subSplitt[1];
    searchCharacter = splittedLine[1].Replace(":", "");
    searchPassword = splittedLine[2];
    //searchStart = "10"; //Test-pass
    //searchEnd = "12";//Test-pass
    //searchCharacter = "d"; //Test-pass
    //searchPassword = "ddvddnmdnlvdddqdcqph"; //Test-pass

    Console.WriteLine("Start: " + searchStart + ", End: " + searchEnd + ", Char: " + searchCharacter + ", Pass: " + searchPassword);
    
    if (validatePasswordPolicy(int.Parse(searchStart), int.Parse(searchEnd), char.Parse(searchCharacter), searchPassword))
    {
        Console.WriteLine("true");
        numberOfValidPass++;
    }
    else
    {
        Console.WriteLine("false");
    }
}
Console.WriteLine("Number of valid passwords: " + numberOfValidPass);

bool validatePasswordPolicy(int start, int end, char character, string password)
{
    char[] charPassword = password.ToCharArray();
    bool returnValue = false;

    for (int i = 0; i < charPassword.Length; i++)
    {
        if (charPassword[i] == character && i >= start-1 && i < end)
        {
            returnValue = true;
        }
    }
    return returnValue;
}