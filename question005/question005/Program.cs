//https://kin.naver.com/qna/detail.nhn?d1id=1&dirId=1040102&docId=433977719
using System;
using static System.Console;

namespace BrainCSharp
{
    internal class HelloWorld
    {
        //프로그램 실행 시작
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : HelloWorld.exe <이름>");
                return;
            }
            WriteLine("Hello, {0}!", args[0]);
        }
    }
}