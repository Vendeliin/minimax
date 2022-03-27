using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimax
{
    internal class App
    {
        public string[] gameField = new string[9];
        public void Run()
        {
            var procced = true;

            string input;
            Console.WriteLine("Hra zacala.");
            Game(startFIeld());
            while (procced)
            {
                Console.WriteLine("Chces hrat dalsi hru? ano/ne");
                input = Console.ReadLine();
                if(input == "ano")
                {
                    Game(startFIeld());
                }
                else
                {
                    procced = false;
                }
            }   
        }
        public string writeField(string[] gameField)
        {
            for (int i = 0; i < gameField.Length; i++)
            {
                Console.Write(gameField[i]);
                if (i == 2 || i == 5)
                {
                    Console.Write("\n");
                }
            }
            return null;
        }
        public string[] startFIeld()
        {
            gameField[0] = "_ ";
            gameField[2] = "_ ";
            gameField[1] = "_ ";
            gameField[3] = "_ ";
            gameField[4] = "_ ";
            gameField[5] = "_ ";
            gameField[6] = "_ ";
            gameField[7] = "_ ";
            gameField[8] = "_ ";

            return gameField;
        }
        public string[] actualField(string field, int fieldPlace)
        {
            gameField[fieldPlace] = field;

            return gameField;
        }
        public void Game(string[] gameField)
        {
            writeField(gameField);
            Console.WriteLine(" ");

            var game = true;

            string[] ActualField;

            int a = 0;

            while(true)
            {
                int input;
                if (game == true)
                {
                    Console.WriteLine("Hrac 1 je na rade.");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (gameField[input - 1] != "X " && gameField[input - 1] != "O ")
                    {
                        gameField[input - 1] = "X ";
                        ActualField = actualField("X ", input - 1);
                        writeField(gameField);
                        game = false;
                        if(checkForWin(gameField) == 1)
                        {
                            Console.WriteLine("Hrac 1 vyhral");
                            break;
                        }
                    } 
                } else
                {
                    Console.WriteLine("Hrac 2 je na rade.");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (gameField[input - 1] != "X " && gameField[input - 1] != "O ")
                    {
                        gameField[input - 1] = "O ";
                        ActualField = actualField("O ", input - 1);
                        writeField(gameField);
                        game = true;
                        if (checkForWin(gameField) == -1)
                        {
                            Console.WriteLine("Hrac 2 vyhral");
                            break;
                        }
                    }
                }
                a++;
                if(a == 9)
                {
                    Console.WriteLine("Je to remiza");
                    break;
                }
            }
        }
        public int checkForWin(string[] gameField)
        {
            string x = "X ";
            string o = "O ";
            if (gameField[0] == x && gameField[1] == x && gameField[2] == x)
            {
                return 1;
            }
            else if (gameField[3] == x && gameField[4] == x && gameField[5] == x)
            {
                return 1;
            }
            else if (gameField[6] == x && gameField[7] == x && gameField[8] == x)
            {
                return 1;
            }
            else if (gameField[0] == x && gameField[4] == x && gameField[8] == x)
            {
                return 1;
            }
            else if (gameField[2] == x && gameField[4] == x && gameField[6] == x)
            {
                return 1;
            }
            else if (gameField[0] == x && gameField[3] == x && gameField[6] == x)
            {
                return 1;
            }
            else if (gameField[1] == x && gameField[4] == x && gameField[7] == x)
            {
                return 1;
            }
            else if (gameField[2] == x && gameField[5] == x && gameField[8] == x)
            {
                return 1;
            }
            else if (gameField[0] == o && gameField[1] == o && gameField[2] == o)
            {
                return -1;
            }
            else if (gameField[3] == o && gameField[4] == o && gameField[5] == o)
            {
                return -1;
            }
            else if (gameField[6] == o && gameField[7] == o && gameField[8] == o)
            {
                return -1;
            }
            else if (gameField[0] == o && gameField[4] == o && gameField[8] == o)
            {
                return -1;
            }
            else if (gameField[2] == o && gameField[4] == o && gameField[6] == o)
            {
                return -1;
            }
            else if (gameField[0] == o && gameField[3] == o && gameField[6] == o)
            {
                return -1;
            }
            else if (gameField[1] == o && gameField[4] == o && gameField[7] == o)
            {
                return -1;
            }
            else if (gameField[2] == o && gameField[5] == o && gameField[8] == o)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
