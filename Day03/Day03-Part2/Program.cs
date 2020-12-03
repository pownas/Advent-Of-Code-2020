using AdventOfCode2020;
using System;
using System.Collections.Generic;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day03-input.txt"); //Read data from: "../../AdventOfCode2020/Data/{dataInputFile}"

long multiplyAllTrees = 1;

//Record for StepsRightDown is created in bottom of this file
List<StepsRightDown> MapList = new List<StepsRightDown>();
MapList.Add(new StepsRightDown(1, 1));
MapList.Add(new StepsRightDown(3, 1));
MapList.Add(new StepsRightDown(5, 1));
MapList.Add(new StepsRightDown(7, 1));
MapList.Add(new StepsRightDown(1, 2));

foreach (var map in MapList)
{
    int numberOfTrees = 0;
    int x = 0;

    Console.WriteLine("\n\nWalking on the map: right=" + map.Right + " down=" + map.Down + "\n");

    for (int y = 0; y < dataList.Count; y++)
    {
        if (y % map.Down is 0)
        {
            char[] rowCharArr = dataList[y].ToCharArray();
            int charPos = x % rowCharArr.Length; //rowCharArr.Length , can also be: dataList[y].Count();

            if (dataList[y][charPos] is '#') // Checks if dataList[row][charPos] is #
            {
                rowCharArr[charPos] = 'X'; //Will mark tree (#) as "X", in output
                numberOfTrees++;
            }
            else
            {
                rowCharArr[charPos] = 'O'; //Will mark open path (.) as "O", in output
            }
            x += map.Right;

            string newOutputString = new string(rowCharArr);
            Console.WriteLine(newOutputString);
        } else
        {
            Console.WriteLine(dataList[y]);
        }
    }

    Console.WriteLine("\nNumber of trees: " + numberOfTrees);
    multiplyAllTrees *= numberOfTrees; //OR same as: multiplyAllTrees = multiplyAllTrees * numberOfTrees;
    Console.WriteLine("\nAll number before * Number of trees = " + multiplyAllTrees);
}

Console.WriteLine("\nANSWER - All number of trees multiplied: " + multiplyAllTrees);


public record StepsRightDown(int Right, int Down); //Creates the Object record: RightDown