using System;
using System.Collections.Generic;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = new List<string>();
dataList = inputFile.ReadData();
bool isNotFound = true;

foreach (var item in dataList)
{
    int item1 = int.Parse(item);
    if (isNotFound) {
        foreach (var line in dataList)
        {
            int item2 = int.Parse(line);

            int result = item1 + item2;
            if (result == 2020)
            {
                Console.WriteLine("Rad 1: " + item);
                Console.WriteLine("Rad 2: " + line);

                int multiply = item1 * item2;

                Console.WriteLine("Svaret multiplicerat: " + multiply);
                isNotFound = false;
            }
        }
    }
}