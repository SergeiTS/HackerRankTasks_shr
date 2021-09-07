using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRankTasks
{
    class Program
    {
        static void Main()
        {
            #region test
            //            List<List<int>> testcases = new List<List<int>>() {
            //            new List<int>() {46934,543563655,46743},
            //new List<int>() {530,533048047,529},
            //new List<int>() {436776012,436776012,436776011},
            //new List<int>() {999999999,999999998,999983945},
            //new List<int>() {59,78693934,2},
            //new List<int>() {49,897910613,48},
            //new List<int>() {124,738996353,2},
            //new List<int>() {999999999,871077789,999999998},
            //new List<int>() {2,576581,1},
            //new List<int>() {526663404,801992888,526663403},
            //new List<int>() {999999998,999999998,1},
            //new List<int>() {126,859530642,126},
            //new List<int>() {1000000000,999999999,1000000000},
            //new List<int>() {107,425601402,2},
            //new List<int>() {381,695699141,380},
            //new List<int>() {11,32020900,6},
            //new List<int>() {468840391,468840391,1},
            //new List<int>() {999999999,29010,1},
            //new List<int>() {31,238250965,2},
            //new List<int>() {6,923562791,1},
            //new List<int>() {39,558119524,38},
            //new List<int>() {121,652798629,1},
            //new List<int>() {94,105224796,94},
            //new List<int>() {9,903414482,5},
            //new List<int>() {1718761,828441828,1718761},
            //new List<int>() {4970962,984250547,4970961},
            //new List<int>() {19,235344290,2},
            //new List<int>() {514824323,514824324,514824323},
            //new List<int>() {181,511813156,180},
            //new List<int>() {66,810757794,2},
            //new List<int>() {154,935852917,154},
            //new List<int>() {1000000000,999999999,999974361},
            //new List<int>() {21,603073253,20},
            //new List<int>() {29,834017184,28},
            //new List<int>() {195446094,586338283,195446093},
            //new List<int>() {93995,173193482,93995},
            //new List<int>() {101,143467773,101},
            //new List<int>() {134,677010612,134},
            //new List<int>() {99,741806010,2},
            //new List<int>() {75,129103876,2},
            //new List<int>() {689371544,689371544,689370115},
            //new List<int>() {28410362,340924345,22721112},
            //new List<int>() {170,780653100,170},
            //new List<int>() {193,945602138,192},
            //new List<int>() {96,23494832,95},
            //new List<int>() {944675683,944675683,20312},
            //new List<int>() {27,546238476,26},
            //new List<int>() {76195990,223258463,489},
            //new List<int>() {999999999,269208525,1},
            //new List<int>() {108,280122192,108},
            //new List<int>() {16,995404080,15},
            //new List<int>() {50158215,451423257,50151646},
            //new List<int>() {4,467711281,4},
            //new List<int>() {145,71654651,144},
            //new List<int>() {1000000000,2985,1},
            //new List<int>() {990301380,1,990271854},
            //new List<int>() {999999999,6413,21476},
            //new List<int>() {2,468939243,1},
            //new List<int>() {399,592025825,398},
            //new List<int>() {8,666688807,8},
            //new List<int>() {7,633100633,2},
            //new List<int>() {12,124444631,7},
            //new List<int>() {8,347412080,5},
            //new List<int>() {999999999,1,999999998},
            //new List<int>() {42774012,765544482,2},
            //new List<int>() {18,359622755,18},
            //new List<int>() {198,964246139,2},
            //new List<int>() {999999999,999999998,999999999},
            //new List<int>() {10,143638249,1},
            //new List<int>() {1946080,978878239,2},
            //new List<int>() {1000000000,999976501,999990588},
            //new List<int>() {999999999,999978713,28209},
            //new List<int>() {433677591,433663369,206662538},
            //new List<int>() {999999999,1,1},
            //new List<int>() {2325,562408200,2},
            //new List<int>() {172,456632596,171},
            //new List<int>() {19,563815520,11},
            //new List<int>() {34339,656699084,101},
            //new List<int>() {1000000000,999997154,999999999},
            //new List<int>() {1000000000,1000000000,90143095},
            //new List<int>() {2,213164653,1},
            //new List<int>() {134,644278309,113},
            //new List<int>() {1000000000,640282835,2},
            //new List<int>() {1000000000,1000000000,999999999},
            //new List<int>() {999999999,999999999,999999999},
            //new List<int>() {999999999,11132,999999998},
            //new List<int>() {197,190791557,197},
            //new List<int>() {1000000000,1000000000,1000000000},
            //new List<int>() {46,56740430,45},
            //new List<int>() {40,277585960,1},
            //new List<int>() {56,306549319,56},
            //new List<int>() {62,803079454,43},
            //new List<int>() {184,834149464,184},
            //new List<int>() {9,526219551,9},
            //new List<int>() {999999999,999999999,583101931},
            //new List<int>() {1000000000,999999999,999999999},
            //new List<int>() {176,719643761,1},
            //new List<int>() {1000000000,999999999,328966243},
            //new List<int>() {65,980609890,37}

            //};
            //            for (int i = 0; i < testcases.Count; i++)
            //            {
            //                int rowsI = testcases[i].Count;
            //                for (int j = 0; j < 1; j++)
            //                {
            //                    Console.WriteLine(SaveThePrisoner.MSaveThePrisoner(testcases[i][j], testcases[i][j + 1], testcases[i][j + 2]));
            //                }
            //            }
            #endregion test

            #region Input
            //long[] ar = new long[] { 7, 69, 2, 221, 8974 };
            int[] ar = new int[] { 1,2,1,2,1,3,2 };
            //int[] scores = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            //int[] apples = new int[] { 2, 3, -4 };
            //int[] oranges = new int[] { 3, -2, -4 };
            //List<int> one = new List<int>() { 1, 2, 2, 3, 1, 2 };
            //List<int> one = new List<int>() { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91 };
            //List<int> bill = new List<int>() { 3, 10, 2, 9 };
            //List<int> pieses = new List<int>() { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 };
            //List<int> birds = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };



            //List<int> two = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<List<int>> mArray = new List<List<int>>() { new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 6, 7, 8 }, new List<int>() { 9, 10, 11, 12 } };
            //List<List<int>> lArray = new List<List<int>>() { new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 6, 7, 8 }, new List<int>() { 9, 10, 11, 12 } };
            //List<List<int>> lArray = new List<List<int>>() { new List<int>() { 1, 2, 3, 4, 0, 0}, new List<int>() { 7, 8, 9, 10, 0 ,0 }, new List<int>() { 13, 14, 15, 16, 0 ,0 },
            //     new List<int>() { 19, 20, 21, 22, 0, 0 }, new List<int>() { 25, 26, 27, 28, 0, 0 }, new List<int>() { 29, 30, 31, 32, 0, 0 }};
            //List<List<int>> lArray = new List<List<int>>() { new List<int>() { 1, 2, 3, 4}, new List<int>() { 7, 8, 9, 10 }, new List<int>() { 13, 14, 15, 16 },
            //            new List<int>() { 19, 20, 21, 22 }, new List<int>() { 25, 26, 27, 28 }};
            //List<List<int>> lArray = new List<List<int>>() { new List<int>() { 1, 2 }, new List<int>() { 3, 4 } };
            //int[][] input = new int[][] {
            //new int[] {1, 2, 3},
            //new int[] {4, 5, 6},
            //new int[] {7, 8, 9},
            //};
            //string time = "07:15:45PM";
            #endregion Input

            #region Output

            //ArrayReverse.Reverse(ar);
            //Console.WriteLine(ArraySum.MArraySum(ar));

            //List<int> res = ArrayCompare.CompareTriplets(one, two);
            //foreach ( int im in res )
            //{
            //    Console.Write($"{im} ");
            //}

            //var ar = new long[] { 100000000100, 100000000200, 100000000300, 100000000400, 100000000500 };
            //Console.WriteLine(BigSum.AVeryBigSum(ar));

            //Console.WriteLine(DiagonalDifference.MDiagonalDifference(lArray));

            //ArrayFractions.PlusMinus(ar);
            //Console.WriteLine(MatrixRotation.GetParity(lArray));

            //MatrixRotation.PrintMatrix(one);

            //ArrayRotation.LeftShiftArray(ar, 3);
            //Console.WriteLine(String.Join(",", ar));



            //MatrixRotationClockWise.MMatrixRotation(lArray, 0);
            //MatrixRotationAntiClockWise.MMatrixRotation(lArray, 1);
            //Console.WriteLine(PrimeNumberCheck.IsPrime(7));
            //FibonacciCaching.AllFib(11);

            //Console.Write("Please, enter a number of steps: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Staircase.PrintStaircase(n);

            //Console.WriteLine(CatsAndMouse.CatAndMouse(1, 3, 2));

            //Console.WriteLine(MagicSquare.FormingMagicSquare(input));
            //MinMaxSum.MiniMaxSum(ar);
            //Console.WriteLine(TimeConversion.MTimeConversion(time));
            //Console.WriteLine(SumDigitsInANumber.SumDigits(1234567));
            //Console.WriteLine(CakeCandles.BirthdayCakeCandles(ar));
            //ApplesOranges.CountApplesAndOranges(7,10,4,12, apples, oranges);
            //Console.WriteLine(ProgrammersDay.DayOfProgrammer(1741));
            //Console.WriteLine(PickingNumbers.MPickingNumbers(one));
            //BonAppetit.MBonAppetit(bill, 1, 7);
            //Console.WriteLine(Kangaroo.MKangaroo(0, 2, 5, 3));
            //Console.WriteLine(SaveThePrisoner.MSaveThePrisoner(3, 7, 3));
            //Console.WriteLine(SaveThePrisoner.MSaveThePrisoner(7, 19, 2));
            //Console.WriteLine(SaveThePrisoner.MSaveThePrisoner(31, 238250965, 2));
            //Console.WriteLine(BetweenTwoSets.GetTotalX(one, two));
            //Console.WriteLine(DivisibleSumPairs.MDivisibleSumPairs(6,3,ar));
            //int[] res = BreakingTheRecords.BreakingRecords(scores);
            //foreach ( int im in res )
            //{
            //    Console.Write($"{im} ");
            //}
            //Console.WriteLine(BirthdayChocolate.Birthday(pieses, 18, 7));
            //Console.WriteLine(MigratoryBirds.MMigratoryBirds(birds));
            //Console.WriteLine(SockMerchant.MSockMerchant(7, ar));
            //Console.WriteLine(DrawingBook.PageCount(6,5));

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //int result = CountingValleys.MCountingValleys(n, s);
            //textWriter.WriteLine(result);
            //textWriter.Flush();
            //textWriter.Close();
            //Console.WriteLine(result);


            #endregion Output


            //Stopping execution statements
            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();

        }
    }

}
