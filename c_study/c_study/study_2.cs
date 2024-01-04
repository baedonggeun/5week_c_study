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
if (currentExp >= requiredExp)
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

//예제2
//1. 홀수 짝수 구분하기
Console.WriteLine("번호를 입력하세요 : ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("짝수입니다.");
}
else
{
    Console.WriteLine("홀수입니다.");
}

//2. 등급 출력
int playerScore = 100;
string playerRank = "";

switch (playerScore / 10)
{
    case 10: //이렇게 case 중첩해서 처리하면 10 과 9는 모두 diamond로 출력됨(break가 9에만 걸려있어서)
    case 9:
        playerRank = "Diamond";
        break;
    case 8:
        playerRank = "Platinum";
        break;
    case 7:
        playerRank = "Gold";
        break;
    case 6:
        playerRank = "Silver";
        break;
    case 5:
        playerRank = "Bronze";
        break;
}

Console.WriteLine(playerRank);

//3. 로그인 프로그램
string id = "id";
string password = "pw";

Console.WriteLine("아이디를 입력하세요 : ");
string inputId = Console.ReadLine();
Console.WriteLine("비밀번호를 입력하세요 : ");
string inputPassword = Console.ReadLine();

if (id == inputId && password == inputPassword)
{
    Console.WriteLine("로그인 성공!");
}
else
{
    Console.WriteLine("로그인 실패...");
}


//4. 알파벳 판별 프로그램
Console.WriteLine("문자를 입력하세요 : ");
char input = Console.ReadLine()[0]; //indexing을 통해 입력받은 문자열 중 0번째 것을 가져옴

if ((input >= 'a' && input <= 'z') || (input >= 'A' && input <= 'Z'))
{
    Console.WriteLine("알파벳입니다.");
}
else
{
    Console.WriteLine("알파벳이 아닙니다.");
}


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
for (int i = 2; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.Write(i + "x" + j + "=" + (i * j) + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

//6. 구구단 세로로 출력하기
for (int i = 1; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.Write(j + "x" + i + "=" + (i * j) + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

//7. 3의 배수는 출력하지 않고 순차적으로 숫자 출력하기
for (int i = 1; i <= 10; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine(i);

    if (i == 7)
    {
        break;
    }
}

//무한 루프와 break, continue의 활용
int sum = 0;

while (true)
{
    Console.Write("숫자를 입력하세요 : ");
    int input = int.Parse(Console.ReadLine());

    if (input == 0)
    {
        Console.WriteLine("프로그램 종료");
        break;
    }

    if (input < 0)
    {
        Console.WriteLine("음수는 무시");
        continue;
    }

    sum += input;
    Console.WriteLine(sum);

}
Console.WriteLine("합계 : " + sum);