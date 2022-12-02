using System;
using System.Collections.Generic;

namespace ConsoleApp37
{
    class Program
    {
        //https://kin.naver.com/qna/detail.naver?d1id=1&dirId=1040102&docId=433948425&mode=answer
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();
            foreach (var item in input)
            {
                if (item < 4)
                {
                    output.Add(item);
                }

                int output_count = output.Count;
                Console.Write("base");
                for (int i = 0; i < output_count; i++)
                {
                    Console.Write(output[i]);
                }

                Console.Write(" sort");

                output.Sort();
                for (int i = 0; i < output_count; i++)
                {
                    Console.Write(output[i]);
                }

                Console.Write(" reverse");

                output.Reverse();
                for (int i = 0; i < output_count; i++)
                {
                    Console.Write(output[i]);
                }

                Console.WriteLine();
            }
        }
    }
}