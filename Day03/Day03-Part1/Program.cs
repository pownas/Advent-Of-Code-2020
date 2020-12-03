using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day03-input.txt"); //Read data from: "../../AdventOfCode2020/Data/{dataInputFile}"

int numberOfTrees = 0;
int x = 0;

for (int y = 0; y < dataList.Count; y++)
{
    char[] rowCharArr = dataList[y].ToCharArray();
    int charPos = x % dataList[y].Count(); //dataList[y].Count() , can also be: rowCharArr.Length and skip using System.Linq;

    //Format on List<string> dataList == dataList[rowNumber][charPosition] 
    //This will result in examples: 
    //first row: dataList[0][0] , second row: dataList[1][3] , third row: dataList[2][6] , ... 
    //on the twelfth row modulus will start to do some work: 
    //twelfth row: dataList[11][2] , thirteenth row: dataList[12][5] ...
    if (dataList[y][charPos] == '#')
    {
        rowCharArr[charPos] = 'X'; //Will mark tree as X, in output
        numberOfTrees++;
    }
    else
    {
        rowCharArr[charPos] = 'O'; //Will open path as O, in output
    }
    x += 3;

    string newOutputString = new string(rowCharArr);
    Console.WriteLine(newOutputString);
}

Console.WriteLine("\nNumber of trees: " + numberOfTrees);