﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCustomerConsumer2.MenuHandler
{
    public class Menu
    {
        public static void MainMenu()
        {
            Boolean status = true;

            while (status)
            {
                Console.WriteLine("What do you want to do? Choose from 1-6");
                Console.WriteLine("Give your choice 1-6, 9:");
                Console.WriteLine("1: Get all customers");
                Console.WriteLine("2: Get one customer by id");
                Console.WriteLine("3: Delete a customer by id");
                Console.WriteLine("4: Add a new customer");
                Console.WriteLine("5: Update a customer");
                Console.WriteLine("6: Print out all customers");
                Console.WriteLine("9: Exit program");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine("You have chosen: " + key);

                if (char.IsDigit(key.KeyChar))
                {
                    int choice = Convert.ToInt32(key.KeyChar) - 48;

                    Console.WriteLine("Choice: " + choice);
                    switch (choice)
                    {
                        case 1:
                            menu1(); break;
                        case 2:
                            menu2(); break;
                        case 3:
                            menu3(); break;
                        case 4:
                            menu4(); break;
                        case 5:
                            menu5(); break;
                        case 6:
                            menu6(); break;
                        case 9:
                            status = false; break;
                        default:
                            Cons
                    }
                
                }
                else
                {
                    Console.WriteLine("You need to input a valid number");
                }
            }
        }
    }
}