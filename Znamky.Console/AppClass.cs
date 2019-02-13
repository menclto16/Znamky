using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZnamkyLibrary;

namespace Znamky.Console
{
    class AppClass
    {
        public MarkHandler markHandler = new MarkHandler();

        public void MainMenu()
        {
            while (true)
            {
                System.Console.WriteLine("1) Show marks");
                System.Console.WriteLine("2) Insert mark");
                System.Console.WriteLine("3) Exit");

                int selection = 0;

                try
                {
                    ConsoleKeyInfo userInput = System.Console.ReadKey();

                    selection = int.Parse(userInput.KeyChar.ToString());
                }
                catch (Exception)
                {
                    System.Console.WriteLine("\n\nNeplatny vstup!");
                }

                switch (selection)
                {
                    case 1:
                        PrintContent();
                        break;
                    case 2:
                        AddContent();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public void PrintContent()
        {
            System.Console.Clear();
            List<Mark> marks = markHandler.GetMarks();
            foreach (var mark in marks)
            {
                System.Console.WriteLine(mark.Subject + " " + mark.Value.ToString() + " " + mark.Weight.ToString() + " " + mark.Comment);
            }
        }

        public void AddContent()
        {
            System.Console.Clear();

            string subject;
            int value = 0;
            int weight = 0;
            string comment;

            System.Console.WriteLine("Enter the subject:");

            subject = System.Console.ReadLine();

            while (true)
            {
                System.Console.Clear();

                System.Console.WriteLine("Enter the mark:");

                try
                {
                    value = int.Parse(System.Console.ReadLine());

                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("\n\nNeplatny vstup!");
                }
            }

            while (true)
            {
                System.Console.Clear();

                System.Console.WriteLine("Enter the weight:");

                try
                {
                    weight = int.Parse(System.Console.ReadLine());

                    break;
                }
                catch (Exception)
                {
                    System.Console.WriteLine("\n\nNeplatny vstup!");
                }
            }

            System.Console.Clear();

            System.Console.WriteLine("Enter the comment:");

            comment = System.Console.ReadLine();

            markHandler.InsertMark(subject, value, weight, comment);
        }
    }
}
