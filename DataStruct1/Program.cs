﻿using System;
using System.Collections.Generic;

namespace DataStruct1
{
internal class Program
{
public static void Main(string[] args)
{
    int[] aiNums = new int[4];
    int aiNumsCount = aiNums.Length;
    aiNums[0] = 1;
    aiNums[1] = 2;
    aiNums[2] = 47;
    aiNums[3] = 69;

    string sBro = "Andy";

    for (int i = 0; i < aiNumsCount; i++)
    {
        Console.WriteLine(aiNums[i]);
        Console.WriteLine(sBro)
    }
  Console.ReadLine();
}
}
}
