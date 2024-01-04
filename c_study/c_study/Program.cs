namespace c_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. 조건문
            /*
             * if문 : ()안의 조건식이 true면 {}안의 코드를 실행하고 false면 실행하지 않거나 다른 조건(else if, else)를 실행함
             * if-else if-else 구조를 가짐
             * else 문은 생략 가능
             * 
             * switch문 : ()안의 변수나 식의 결과에 따라 다른 코드 블록(case문)을 실행
             * switch - case break - default break(생략 가능) 형식으로 작동
             * 
             * 
             */

            //cf)삼항 연산자
            /*
             * if 문의 간단한 형태로 조건식의 결과에 따라 두 값을 선택
             *(조건식) ? 참일 경우의 값 : 거짓일 경우의 값;
             */
            int currentExp = 1200;
            int requiredExp = 2000;

            string result = (currentExp >= requiredExp) ? "레벨업 가능" : "레벨업 불가능";
            Console.WriteLine(result);

            //if-else 문으로 작성 시
            if(currentExp >= requiredExp)
            {
                Console.WriteLine("레벨업 가능");
            }
            else
            {
                Console.WriteLine("레벨업 불가능");
            }

            //cf)디버그
            /*
             * break point : 원하는 코드에 키보드 커서를 놓고 f9를 누르거나 그 줄의 왼쪽에 빨간 동그라미 찍기
             * break point를 찍은 후 F5를 누르면 디버깅을 시작하며 break point에서 멈춤
             * 조사식 호출스택을 주로 확인해 디버그함 (창이 안 나올 땐 디버그 - 창 - 호출스택 / 조사식 누르면 됨)
             * F10을 누르면 하나의 코드씩 넘어감 이걸 확인하면서 오류 확인
             * 
             */
        }
    }
}
