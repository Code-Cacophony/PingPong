using System;

class PingPong
{

  static void Main()
  {
    Console.WriteLine("Enter a number and I will ping-pong it.");
    string userInput = Console.ReadLine();
    int userNumbers = int.Parse(userInput);

    Console.WriteLine("");
    {
      for (int num = 1; num <= userNumbers; num++)
      {
        if (num % 3 == 0 && num % 5 == 0)
        {
          Console.WriteLine("Ping-Pong");
          //break;
        }
        else
        {
          if (num % 3 == 0)
          {
            Console.WriteLine("ping");
            //break;
          }
          else
          {
            if (num % 5 == 0)
            {
              Console.WriteLine("pong");
              //break;
            }

            else
            {
              Console.WriteLine(num);
            }
          }
        }
      }
    }
  }
}