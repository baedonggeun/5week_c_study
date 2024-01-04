using System.Runtime.ExceptionServices;

namespace c_study
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //6. 반복문
            /*
             * for문
             * for(초기식; 조건식; 증감식) {} 
             * 조건식을 만족하는 동안 {}안의 코드를 계속 실행
             * 회차가 구분되서 동작하는 경우 사용하기 편함
             * 
             * while문
             * while(조건식) {}
             * 조건식이 참인 경우 {}안의 코드를 게속 실행
             * 조건이 우선 시 되는 경우 사용하기 편함
             * 
             * do-while문
             * do {}while(조건식)
             * {}안의 내용은 최초 1번 무조건 실행하고 조건식을 만족할 경우 반복해 실행
             * for문도 while문도 조건에 부합하지 않으면 1번도 실행하지 않을 수 있음
             * 적어도 1번은 실행이 필요한 경우 사용
             * 
             * foreach문
             * foreach(자료형 변수 in 배열 또는 컬렉션) {배열 또는 컬렉션의 모든 요소에 대해 반복적으로 실행되는 코드}
             * 배열이나 컬렉션에 대한 반복문을 작성할 때 사용
             * ex)
             * string[] inventory = {"검", "방패", "활", "화살", "물약" };
             * foreach(string item in inventory)
             * {
             *      Console.WriteLine(item);
             * }
             * inventory 배열 안의 요소를 item이라 칭하고 반복문이 배열을 처음부터 돌면서 item을 출력하는 코드
             * 
             * 중첩반복문
             * 반복문 안에 반복문
             * 
             * break와 continue
             * break는 반복문을 중지시키는 역할
             * continue는 현재 반복을 중지하고 다음 반복을 진행하는 역할
             * 
             */

            //예제2
            //5. 구구단 출력
            for(int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.Write(i + "x" + j + "=" + (i * j) + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //6. 구구단 세로로 출력하기
            for (int i = 1; i <= 9; i++)
            {
                for(int j = 2; j <= 9; j++)
                {
                    Console.Write(j + "x" + i + "=" + (i * j) + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //7. 3의 배수는 출력하지 않고 순차적으로 숫자 출력하기
            for(int i = 1;i <= 10; i++)
            {
                if(i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);

                if(i == 7)
                {
                    break;
                }
            }

            //무한 루프와 break, continue의 활용
            int sum = 0;

            while(true)
            {
                Console.Write("숫자를 입력하세요 : ");
                int input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    Console.WriteLine("프로그램 종료");
                    break;
                }

                if(input < 0)
                {
                    Console.WriteLine("음수는 무시");
                    continue;
                }

                sum += input;
                Console.WriteLine(sum);

            }
            Console.WriteLine("합계 : " + sum);


        }
    }
}
