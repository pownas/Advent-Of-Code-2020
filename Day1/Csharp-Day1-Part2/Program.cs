using System;
using System.Collections.Generic;

AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData();
bool isNotFound = true;

foreach (var lineItem1 in dataList)
{
    int item1 = int.Parse(lineItem1);
    if (isNotFound)
    {
        foreach (var lineItem2 in dataList)
        {
            int item2 = int.Parse(lineItem2);
            if (isNotFound)
            {
                foreach (var lineItem3 in dataList)
                {
                    int item3 = int.Parse(lineItem3);

                    int result = item1 + item2 + item3;
                    if (result == 2020)
                    {
                        Console.WriteLine("Rad 1: " + lineItem1);
                        Console.WriteLine("Rad 2: " + lineItem2);
                        Console.WriteLine("Rad 3: " + lineItem3);

                        int multiply = item1 * item2 * item3;

                        Console.WriteLine("Svaret multiplicerat: " + multiply);
                        isNotFound = false;
                    }
                }
            }
        }
    }
}