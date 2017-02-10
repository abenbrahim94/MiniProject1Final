using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmed_Benbrahim_Mini_Project_1
{
    class Program
    {
        enum Planets
        {
            Mercury = 1, Venus, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto, Exit// constant list/ enum is used to declare an enumeration
        }
        static void Main()
        {
            try // Try to execute the code block below if there is an error it will be caught using catch
            {
                //Variables
                const double Mercury = 0.37; // Constant double means the value of the variable won't change            
                const double Venus = 0.88;
                const double Mars = 0.38;
                const double Jupiter = 2.64;
                const double Saturn = 1.15;
                const double Uranus = 1.15;
                const double Neptune = 1.12;
                const double Pluto = 0.04;
                double mercury;  // double allows us to use decimal points etc
                double venus;
                double mars;
                double jupiter;
                double saturn;
                double uranus;
                double neptune;
                double pluto;
                double weight;
                string prompt; // string is a text, here we used it as user input since all user inputs are strings by default
                string r;
                int chosenPlanet; // an integer only stores whole numbers

                //Codes
                do // this will excute the code block until our condition becomes false 
                {
                    Console.Clear(); // clears the console screen

                    Console.WriteLine("-----------Mini Project 1----------- "); // title
                    Console.WriteLine("\n");// skip line
                    Console.WriteLine("In the following program, you will be able to calculate your weight in various planets.");// program info
                    Console.WriteLine("\n");
                    Console.WriteLine("Menu of the planet");// console.writeline(); allows us to put in text for the user to read
                    Console.WriteLine("==== == === ======");
                    Console.WriteLine("1 - Mercury ");
                    Console.WriteLine("2 - Venus ");
                    Console.WriteLine("3 - Mars ");
                    Console.WriteLine("4 - Jupiter ");
                    Console.WriteLine("5 - Saturn ");
                    Console.WriteLine("6 - Uranus ");
                    Console.WriteLine("7 - Neptune ");
                    Console.WriteLine("8 - Pluto ");
                    Console.WriteLine("9 - Exit");
                    Console.WriteLine("\n");
                    Console.WriteLine("Please choose a planet of your choice");

                    //Console.ReadLine(); reads what the user inputs
                    prompt = Console.ReadLine(); // prompt is our string, aka user input 
                    Console.Write("\n");
                    chosenPlanet = Convert.ToInt32(prompt); //chosenPlanet is an integer. so here we are converting the user input named prompt which is a string to an integer and assigning it to var chosenPlanet

                }

                while (chosenPlanet > 9 || chosenPlanet < 1); //this is the loop condition




                switch ((Planets)(chosenPlanet)) //controls the list/menu
                {
                    case Planets.Mercury:
                        Console.WriteLine("You chose Mercury");
                        break;
                    case Planets.Venus:
                        Console.WriteLine("You chose Venus");
                        break;
                    case Planets.Mars:
                        Console.WriteLine("You chose Mars");
                        break;
                    case Planets.Jupiter:
                        Console.WriteLine("You chose Jupiter");
                        break;
                    case Planets.Saturn:
                        Console.WriteLine("You chose Saturn");
                        break;
                    case Planets.Uranus:
                        Console.WriteLine("You chose Uranus");
                        break;
                    case Planets.Neptune:
                        Console.WriteLine("You chose Neptune");
                        break;
                    case Planets.Pluto:
                        Console.WriteLine("You chose Pluto");
                        break;
                    case Planets.Exit:
                        Console.WriteLine("You chose to Exit!! GoodBye!!!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("****************************");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        break;

                }
                // Asks user to input weight
                Console.WriteLine("\nNow input your weight in (LBS)");
                prompt = Console.ReadLine();
                Console.Write("\n");
                weight = Convert.ToDouble(prompt);//weight is a double. so here we are converting the user input named prompt which is a string to a double and assigning it to var weight

                //Calculations
                mercury = weight * Mercury;
                venus = weight * Venus;
                mars = weight * Mars;
                jupiter = weight * Jupiter;
                saturn = weight * Saturn;
                uranus = weight * Uranus;
                neptune = weight * Neptune;
                pluto = weight * Pluto;

                switch ((Planets)(chosenPlanet))// controls the list/menu and gives the user the final result
                {
                    case Planets.Mercury:
                        Console.WriteLine("Since you chose Mercury. Therefore your weight in Mercury would be {0:#.#} LBS", mercury); // #.# - limits the output to one decimal place
                        break;
                    case Planets.Venus:
                        Console.WriteLine("Since you chose Venus. Therefore your weight in Venus would be {0:#.#} LBS", venus);
                        break;
                    case Planets.Mars:
                        Console.WriteLine("Since you chose Mars. Therefore your weight in Mars would be {0:#.#} LBS", mars);
                        break;
                    case Planets.Jupiter:
                        Console.WriteLine("Since you chose Jupiter. Therefore your weight in Jupiter would be {0:#.#} LBS", jupiter);
                        break;
                    case Planets.Saturn:
                        Console.WriteLine("Since you chose Saturn. Therefore your weight in Saturn would be {0:#.#} LBS", saturn);
                        break;
                    case Planets.Uranus:
                        Console.WriteLine("Since you chose Uranus. Therefore your weight in Uranus would be {0:#.#} LBS", uranus);
                        break;
                    case Planets.Neptune:
                        Console.WriteLine("Since you chose Neptune. Therefore your weight in Neptune would be {0:#.#} LBS", neptune);
                        break;
                    case Planets.Pluto:
                        Console.WriteLine("Since you chose Pluto. Therefore your weight in Pluto would be {0:#.#} LBS", pluto);
                        break;
                    case Planets.Exit:
                        Console.WriteLine("You chose to Exit!! GoodBye!!!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\n");
                        Console.WriteLine("****************************");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        break;
                }

                // asks user if they want to exit or restart
                Console.WriteLine("\nPress 'R' To Restart or Press Enter To Exit");
                r = Console.ReadLine();
                if (r.ToUpper() == "R")// r.To.Upper converts letter r that the user inputs to uppercase and the '=="R" ' means that it will work the same whether the user inputs upper or lower case 'r'
                {
                    Main();   // The if statememt we used says that if the the user inputs r go back to Main method in other words Restart
                    Console.Read();
                }

            }
            catch (Exception error) // this catches any invalid input that might crash the program
            {
                Console.WriteLine("Invalid Entry!!!"); //Here we are informing the user that they have entered an invalid entry. They can restart or exit if they want
                Console.WriteLine("\nPress 'R' To Restart or Press Enter To Exit");
                string r = Console.ReadLine();
                if (r.ToUpper() == "R")
                {
                    Main();
                    Console.ReadKey();
                }
            }
        }
    }
}


