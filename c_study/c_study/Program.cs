using System.Runtime.ExceptionServices;

namespace c_study
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //8. 가위바위보
            string[] choices = { "scissors", "rock", "paper" };
            string playerChoice = "";
            string computerChoice = choices[new Random().Next(0, 3)];

            while(playerChoice != computerChoice)
            {
                Console.Write("rock scissors paper 중 하나를 선택하세요 : ");
                playerChoice = Console.ReadLine();

                if(playerChoice == computerChoice) 
                {
                    Console.WriteLine("비겼습니다.");
                }
                else if(
                    (playerChoice == "scissors" && computerChoice == "paper") || 
                    (playerChoice == "rock" && computerChoice == "scissors") || 
                    (playerChoice == "paper" && computerChoice == "rock")
                    )
                {
                    Console.WriteLine("플레이어 승리!");
                }
                else
                {
                    Console.WriteLine("컴퓨터 승리!");
                }
            }


            //9. 숫자 맞추기(up down 게임)
            int targetNumber = new Random().Next(1, 101);
            int guess = 0;
            int count = 0;

            Console.WriteLine("1부터 100 사이의 숫자를 맞춰보세요.");
            while(guess !=  targetNumber)
            {
                Console.Write("1부터 100 사이의 숫자를 입력해 주세요 : ");
                guess = int.Parse(Console.ReadLine());

                if(guess == targetNumber) 
                { 
                    Console.WriteLine("맞췄습니다!");
                    Console.WriteLine("시도 횟수 : {0}", count);
                }
                else if(guess < targetNumber)
                {
                    Console.WriteLine("up");
                }
                else
                {
                    Console.WriteLine("down");
                }
                count++;
            }
            

        }
    }
}
