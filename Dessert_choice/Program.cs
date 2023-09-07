using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessert_choice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string answer;

            Console.WriteLine("I hope you enjoyed your meal! Would you like dessert? y/n" );
            string answer = Console.ReadLine();


           

                if (answer == "y")
                {
                    
                    Console.Clear();
                    DessertChoice();

                
                }
                else if (answer == "yes")
                {
                        
                        Console.Clear();
                    DessertChoice();
                }
                else if(answer == "yup")
                {
               
                        Console.Clear();
                    DessertChoice();
                }
                else if (answer == "yep")
                {
                        
                        Console.Clear();
                    DessertChoice();
                }
                else if (answer == "yea")
                {
                        
                        Console.Clear();
                    DessertChoice();
                }
                else if (answer == "sure")
                {
                        
                        Console.Clear();
                    DessertChoice();
                }
                else if (answer == "please")
                {
                        
                        Console.Clear();
                    DessertChoice();
                }
                else if (answer == "indeed")
                {
                        
                        Console.Clear();
                    DessertChoice();
                }
                else if (answer == "true")
                {
                        
                        Console.Clear();
                    DessertChoice();
                }
                else if (answer == "n")
                {
                    
                    Console.WriteLine("alright, i will get that bill for you.");
                    Console.ReadLine();
                }
                else if (answer == "no")
                {
                    
                    Console.WriteLine("alright, i will get that bill for you.");
                    Console.ReadLine();
                }
                else if (answer == "nope")
                {
                    
                    Console.WriteLine("alright, i will get that bill for you.");
                    Console.ReadLine();
                }
                else if (answer == "nuh uh")
                {
                    
                    Console.WriteLine("alright, i will get that bill for you.");
                    Console.ReadLine();
                }
                else if (answer == "false")
                {
                    
                    Console.WriteLine("alright, i will get that bill for you.");
                    Console.ReadLine();
                }
                else if (answer == "never")
                {
                    
                    Console.WriteLine("alright, i will get that bill for you.");
                    Console.ReadLine();
                }
                else if (answer == "no thanks")
                {
                    
                    Console.WriteLine("alright, i will get that bill for you.");
                    Console.ReadLine();
                }
                else
                {
                    
                    Console.WriteLine("Not a valid answer. Try again");
                    
                }


        }

        static void DessertChoice()
        {
            string answer;
            string dessertChoice;
            Console.WriteLine("Sweet! We have a wide variety of Dessert options, such as:");
            Console.WriteLine("Pumpkin Pie: p");
            Console.WriteLine("Ultimate Chocolate Brownie: b");
            Console.WriteLine("Honey Beignets: h");

            answer = Console.ReadLine();

            if (answer == "p")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "P")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "pie")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "Pie")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "Pumpkin Pie")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "pumpkin pie")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "pumpkin")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "Pumpkin")
            {
                dessertChoice = "Pumpkin Pie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "b")
            {
                dessertChoice = "Ultimate Chocolate Brownie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "Ultimate Chocolate Brownie")
            {
                dessertChoice = "Ultimate Chocolate Brownie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "ultimate chocolate brownie")
            {
                dessertChoice = "Ultimate Chocolate Brownie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "brownie")
            {
                dessertChoice = "Ultimate Chocolate Brownie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "Brownie")
            {
                dessertChoice = "Ultimate Chocolate Brownie";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "Honey Beignets")
            {
                dessertChoice = "Honey Beignets";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "honey beignets")
            {
                dessertChoice = "Honey Beignets";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "h")
            {
                dessertChoice = "Honey Beignets";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "beignets")
            {
                dessertChoice = "Honey Beignets";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else if (answer == "Beignets")
            {
                dessertChoice = "Honey Beignets";
                Console.WriteLine($"Excellent Choice, I will have {dessertChoice} out for you right away!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("that is not a valid option, please try again.");
                Console.ReadLine();
            }

        }
    }
}
