namespace c_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("자동 완성 연습");

            //1. 프로그래밍 기본 요소
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

            //주석
            /*
             * 주석은 코드 대체 x
             * 주석의 내용은 명확!
             * 주석은 코드 변경에 따라 업데이트!
             * 필요한 경우에만 사용(코드 명확 의도 확실하면 굳이 사용 x)
             * ctrl K C : 주석 처리 / ctrl K U : 주석 해제
             */

            //코드 자동 완성과 템플릿 이용
            /*
             * 코드 일부 입력 후 Tab 키 누르면 자동 완성
             * for문 같은건 for 키워드 입력 후 Tab 2번 누르면 for문 템플릿 생성
             * 입력하다 오타 났을 때 다시 자동 완성 기능 키려면 ctrl + spacebar 사용
             */

            //2. 변수와 자료형
            /*
             * @@자료형
             * 주로 쓰이는 기본 자료형
             * 정수 : int / 실수 : float double / 문자와 문자열 : char string / TorF : bool
             * 각각의 자료형은 메모리의 크기와 표현 범위가 다름
             * 변수의 자료형을 세분화 해서 쓰는 이유
             * -메모리의 효율적인 사용
             * -정확한 데이터 표현
             * -type 안정성(해당 자료형의 범위 넘어가면 오류 표시로 코드 안정성 보장)
             * 
             * @@리터럴 : 소스 코드의 고정된 값을 나타내는 표기법
             * ex)10, const age = 40;, \n 등등
             * 
             * @@변수 선언과 초기화
             * 자료형 변수이름 = 초기화값;
             * int age = 40;
             * 선언 이후 초기화도 가능
             * 한 번에 여러 개 선언 및 초기화 가능
             * 변수명 설정 시, c# 기본 키워드(bool type byte string등등) 제외하고 설정
             * 어떤 목적으로 사용되는지 정확하게 알 수 있는 변수명으로 작성
             * 
             * @@식별자 : 변수 메서드 클래스 인터페이스 등에 사용되는 이름
             * 식별자 사용 규칙
             * -첫 문자는 알파벳 또는 _
             * -두 번째 문자부터 알파벳 _ 또는 숫자
             * -대소문자 구별
             * -키워드 제외한 이름 생성
             * 
             * @@코드 컨벤션 : 개발자들 사이에서 약속된 코드 작성 규칙
             * 가독성 증가 유지 보수의 용이
             * 
             * 규칙1 : 식별자 표기법
             * -변수가 아닌 클래스 메서드 프로퍼티 함수 등엔 첫 글자를 대문자 및 이어지는 단어 첫 글자도 대문자
             * ex)ClassName MethodName
             * -변수 매개변수 로컬변수 등엔 첫 글자는 소문자 이 후 단어의 첫 글자는 대문자
             * ex)variableName parameterName
             * 
             * 규칙2 : 들여 쓰기(탭 또는 스페이스 4칸을 사용해 코드 블록을 들여씀)
             * 
             * 규칙3 : 중괄호는 항상 새로운 줄에서 시작
             * 
             * 규칙4 : 관련 없는 코드 사이에는 빈 줄을 사용하여 구분하며 메서드 클래스 등의 블록 사이는 두 줄 띄어 쓰기
             * 
             * 규칙5 : 여러 줄 주석 사용 시 //말고 여러 줄 주석 사용
             *
             *@@형 변환 : 자료형이 다른 변수 간에 값을 할당하거나 연산을 수행하기 위함
             *명시적 형변환 : 직접 변환하려는 자료형으로 코드 작성하여 변환
             *int num1 = 10;
             *long num2 = (long)num1;
             *
             *암시적 형변환 : 시스템 상에서 자동으로 자료형을 변환해 주는 것
             *-작은 데이터를 큰 데이터에 대입 시 큰 데이터 타입으로 자동 변환
             *-리터럴 값이 대입되는 경우 리터럴 값의 데이터 타입을 판별해 변수에 암시적으로 형변환
             *-정수형과 부동소수점형 간의 연산 결과는 부동소수점형으로 변환(더 큰 데이터 타입으로 변환)
             */

            //입력과 출력
            //출력은 write, writeline 함수로, 입력은 readline 함수로
            Console.Write("Enter your name : ");

            //readline 위에 마우스 올리면 항상 string으로 입력값을 저장한다는걸 알 수 있음
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);

            //한 줄에 여러 값 입력받기
            Console.Write("Enter two numbers : ");
            string input = Console.ReadLine(); //"10 20" 같은 문자열을 입력받음

            string[] numbers = input.Split(' '); //문자열을 공백으로 구분하여 배열로 만듦
            int num1 = int.Parse(numbers[0]); //첫 번째 값을 정수로 변환하여 저장
            int num2 = int.Parse(numbers[1]); //첫 번째 값을 정수로 변환하여 저장

            int sum = num1 + num2;

            Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum);

            //var 키워드 : var를 사용해 변수를 선언하면 자료형이 초기화 값에 따라 컴파일러에 의해 자동 결정
            var num = 10; //int 자료형으로 결정됨
            var name_kero = "kero"; //string 자료형으로 결정됨
            var pi = 3.141592; //double 자료형으로 결정됨



        }
    }
}
