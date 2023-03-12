using PolymorphsyimProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsyimProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Figures project");
            Console.WriteLine("Project is developed by Isa Sadigov");
            Console.WriteLine("*****************");


            while (true)
            {
                Console.WriteLine("Please choose one of theese prosses");
                Console.WriteLine("1- Rectangle");
                Console.WriteLine("2- Triangle");
                Console.WriteLine("3- Quads");
                Console.WriteLine("4- Press q to exit");

                string Choice = Console.ReadLine();

                if (Choice == "q")
                {
                    break;
                }

                else if (Choice == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("1-Calculate rectangle area");
                        Console.WriteLine("2-Show info about rectangle");
                        Console.WriteLine("3-Press 'q' to exit from rectangle");

                        string recChoice = Console.ReadLine();

                        if (recChoice == "1")
                        {
                            Console.WriteLine("Please enter rectangle's width");
                            int recWidth = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please enter rectangle's heigth");
                            int recHeigth = int.Parse(Console.ReadLine());
                            Rectangle rectangle = new Rectangle("Rectangle", recWidth, recHeigth);
                            rectangle.Calculate();
                        }

                        else if (recChoice == "2")
                        {

                            Console.WriteLine("Please enter rectangle's width");
                            int recWidth = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please enter rectangle's heigth");
                            int recHeigth = int.Parse(Console.ReadLine());
                            Rectangle rectangle = new Rectangle("Rectangle", recWidth, recHeigth);
                            rectangle.ShowInfo();
                        }
                        else if (recChoice == "q")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter step number correctly");
                            break ;
                        }
                    }
                }
                else if(Choice == "2")
                {

                    Console.WriteLine("1-Calculate triangle area");
                    Console.WriteLine("2-Show info about triangle");
                    Console.WriteLine("3-Press 'q' to exit from triangle");

                    string triChoice = Console.ReadLine();

                    while (true)
                    {
                        if(triChoice == "1")
                        {
                            Console.WriteLine("Please enter heigth of triangle");
                            int triHeigth = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please enter weigth of triangle");
                            int triWeigth=int.Parse(Console.ReadLine());
                            Console.WriteLine("Calculating...");

                            Triangle triangle = new Triangle("Triangle", triWeigth, triHeigth);
                            triangle.Calculate();
                        }
                        else if(triChoice == "2")
                        {
                            Console.WriteLine("Please enter heigth of triangle");
                            int triHeigth = int.Parse(Console.ReadLine());

                            Console.WriteLine("Please enter weigth of triangle");
                            int triWeigth = int.Parse(Console.ReadLine());

                            Triangle triangle = new Triangle("Triangle", triWeigth, triHeigth);
                            triangle.ShowInfo();
                        }
                        else if(triChoice == "q")
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter step number correctly");
                            break;
                        }
                    }
                }
                else if(Choice == "3")
                {

                    Console.WriteLine("1-Calculate Quads area");
                    Console.WriteLine("2-Show info about quads");
                    Console.WriteLine("3-Press 'q' to exit from quads");
                    string quadChoice = Console.ReadLine();

                    while (true)
                    {
                        if (quadChoice == "1")
                        {
                            Console.WriteLine("Please enter a part of Quads");
                            int quadPart = int.Parse(Console.ReadLine());

                            Quad quad = new Quad("Quads", quadPart);
                            quad.Calculate();
                        }
                        else if (quadChoice == "2")
                        {
                            Console.WriteLine("Please enter a part of Quads");
                            int quadPart = int.Parse(Console.ReadLine());

                            Quad quad = new Quad("Quads", quadPart);
                            quad.ShowInfo();
                        }
                        else if (quadChoice == "q")
                        {
                            Console.WriteLine("Exiting...");
                            break ;
                        }
                        else
                        {
                            Console.WriteLine("Please enter step number correctly");
                            break;
                        }
                    }

                }


            }
        }
    }
}

