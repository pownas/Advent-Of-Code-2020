using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day06-input.txt");

var PassengerGroups = new List<Group>();
var PassengerGroup = new Group();

for (var i = 0; i < dataList.Count; i++)
{
    if (dataList[i] != String.Empty)
        PassengerGroup.PersonsAnswers.Add(dataList[i].ToCharArray());

    if (dataList[i] == String.Empty || i == dataList.Count - 1)
    {
        PassengerGroups.Add(PassengerGroup);
        PassengerGroup = new Group();
    }
}

int anyoneYes = PassengerGroups.Select(p => p.ListUniqueAnyoneYes().Count).Sum();
int everyoneYes = PassengerGroups.Select(p => p.ListUniqueEveryoneYes().Count).Sum();

Console.WriteLine($"The sum of anyone yes counts is {anyoneYes}");
Console.WriteLine($"The sum of everyone yes counts is {everyoneYes}");


public class Group
{
    public List<char[]> PersonsAnswers { get; set; }

    public Group()
    {
        PersonsAnswers = new List<char[]>();
    }

    public List<char> ListUniqueAnyoneYes()
    {
        List<char> anyoneYesResult = null;

        foreach (var person in PersonsAnswers)
        {
            if (anyoneYesResult == null)
                anyoneYesResult = person.ToList();
            else 
                anyoneYesResult = anyoneYesResult.Union(person.ToList()).ToList();
        }

        return anyoneYesResult;
    }

    public List<char> ListUniqueEveryoneYes()
    {
        List<char> everyYesResult = null;

        foreach (var person in PersonsAnswers)
        {
            if (everyYesResult == null)
                everyYesResult = person.ToList();
            else 
                everyYesResult = everyYesResult.Intersect(person.ToList()).ToList();
        }

        return everyYesResult;
    }
}