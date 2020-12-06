using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day05-input.txt");

List<int> seatList = new List<int>();

foreach (string boardingpass in dataList)
{
	int minRow = 0;
	int maxRow = 127;
	int minColumn = 0;
	int maxColumn = 7;

	foreach (char c in boardingpass)
	{
		if (c is 'F')
			maxRow = maxRow - ((maxRow - minRow) / 2) - 1;
		else if (c is 'B')
			minRow = minRow + (maxRow - minRow) / 2 + 1;
		else if (c is 'R')
			minColumn = minColumn + (maxColumn - minColumn) / 2 + 1;
		else if (c is 'L')
			maxColumn = maxColumn - ((maxColumn - minColumn) / 2) - 1;
	}

	int seatID = minRow * 8 + minColumn;
	seatList.Add(seatID);

	Console.WriteLine(boardingpass + ": row " + minRow + ", column " + minColumn + ", seatID " + seatID);
}

Console.WriteLine("\n\n" + seatList.Max());

seatList.Sort();

foreach (var seat in seatList)
{
    for (int i = 0; i < seatList.Max(); i++)
    {
        if (seatList[i] != seat)
            Console.WriteLine("Free seats: " + seat);
    }
}