namespace c_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("자동 완성 연습");

            /*
             * 
             * 
            //c# 에서 기본적으로 제공하는 namespace 를 사용하기 위해 참조해야하는 코드
            //console 클래스를 사용하기 위해 필요 
            using System;
            
            //클래스 및 기타 namespace의 컨테이너
            namespace HelloWorld
            //
            {
                //c#클래스를 정의하는 키워드
                //클래스명 = program
                class program
                {
                    //c#의 진입점(entry point)
                    //main 메서드는 프로그램이 시작할 때 자동으로 호출되는 메서드로 필수
                    static void Main(string[] args)
                    {
                        //콘솔에 출력할 내용을 지정하는 코드
                        Console.WriteLine("Hello World!");
                    }
                }
            }
             * 
             * 
             */

            //줄 바꿈 문자열 추가하여 다음 WriteLine 작성 시 하단에 출력
            Console.WriteLine(10);
            Console.WriteLine(3.141592);
            Console.WriteLine(3 + 3);

            //줄 바꿈 문자열을 추가하지 않아 바로 이어서 출력
            Console.Write("Hello!");
            Console.Write("We are Learning!");

            //이스케이프 시퀸스 : 문자열 안에 삽입하는 특수 기호
            /*
             *  \' : 작은 따옴표 삽입
             *  \" : 큰 따옴표 삽입
             *  \| : 역슬래시(|) 삽입
             *  \n : 줄 바꿈 삽입
             *  \r : 현재 줄 맨 앞으로 이동
             *  \t : 탭 삽입
             *  \b : 백 스페이스 삽입
             */
            Console.WriteLine("\\\n");
            Console.WriteLine("\'\tHello!\b\"");
        }
    }
}
