using AdventOfCode2020;
using System;
using System.Collections.Generic;
using System.Linq;


AppDataInput inputFile = new AppDataInput();
List<string> dataList = inputFile.ReadData("Day08-input.txt");
List<Instruction> instructions = new List<Instruction>();

foreach (var line in dataList)
{
    instructions.Add(Instruction.Parse(line));
}

Console.WriteLine("ANSWER to part 1: " + PartOne() ); //Solution to part 1
Console.Write("\n");
Console.WriteLine("ANSWER to part 2: " + PartTwo() ); //Solution to part 2


int PartOne() {
    Execute(instructions, -1, out var accumulator);
    return accumulator;
}

int PartTwo()
{
    var accumulator = 0;

    for (var i = 0; i < instructions.Count; i++)
    {
        if (instructions[i].Operation == "acc")
            continue;

        if (Execute(instructions, i, out accumulator))
            return accumulator;
    }
    throw new NullReferenceException("There are no solution to this part...");
}

bool Execute(List<Instruction> instructions, int pointerFix, out int accumulator)
{
    var executed = new int[instructions.Count];
    var pointer = 0;
    accumulator = 0;

    while (pointer >= 0 && pointer < instructions.Count)
    {
        executed[pointer]++;

        if (executed.Any(e => e > 1))
        {
            return false;
        }

        var instruction = instructions[pointer];

        if (pointerFix == pointer)
        {
            instruction = instruction.Operation == "jmp"
                ? new Instruction("nop", instruction.Argument)
                : new Instruction("jum", instruction.Argument);
        }

        switch (instruction.Operation)
        {
            case "acc":
                accumulator += instruction.Argument;
                pointer++;
                break;
            case "jmp":
                pointer += instruction.Argument;
                break;
            case "nop":
                pointer++;
                break;
        }
    }
    return true;
}

public class Instruction {
    /// <summary>
    /// Name on Operation
    /// </summary>
    public string Operation { get; set; }
    /// <summary>
    /// Number of lines to jump via Argument
    /// </summary>
    public int Argument { get; set; }

    public Instruction(string op, int arg)
    {
        Operation = op;
        Argument = arg;
    }

    public static Instruction Parse(string line)
    {
        var splitted = line.Split(" ");
        return new Instruction(splitted[0], int.Parse(splitted[1]));
    }
}