// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using sortalgorithm;

Console.WriteLine("Hello, World!");


algorithm Is=new algorithm();

Stopwatch timer=new Stopwatch();
int[] Arraydisorder=new int[] {15,23,59,45,12,4,1,26,36,23,25,89,105,532,2,48,1547,3,5,7,6,8,11,10,9,13,14,18,17,16,75,92,90};

// timer.Start();
//     var sorted=Is.BubbleSort(Arraydisorder);
// timer.Stop();

// foreach (var item in sorted)
// {
//     System.Console.Write(" - {0}",item);
// // }
// System.Console.WriteLine();
// System.Console.WriteLine(timer.Elapsed);
System.Console.WriteLine("------------------------");
System.Console.WriteLine(Is.MergeSort(Arraydisorder));

