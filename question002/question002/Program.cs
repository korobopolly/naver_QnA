//https://kin.naver.com/qna/detail.naver?d1id=1&dirId=1040101&docId=433964808&mode=answer

namespace MyNamespace
{
	class MyClass
	{
		static void Main(string[] args)
		{

            int[] numbers = new int[3];

            Console.WriteLine("숫자를 입력해주세요.");
			for (int i = 0; i < 3; i++)
			{
                Console.Write("입력 : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine("배열 값 출력 : " + numbers[i] + " ");
			}
        }
	}
}