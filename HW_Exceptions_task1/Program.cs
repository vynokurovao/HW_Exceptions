using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task1
{ 
    class Program
    {
        private const int WorkersQuantity = 5;

        static void FillArrayFromShell(WorkersDataStorage workers)
        {
            for (int i = 0; i < WorkersQuantity; i++)
            {
                bool ready = false;
                while (!ready)
                {
                    Console.WriteLine("Please, enter worker's name and initials");
                    string name = Console.ReadLine();

                    Console.WriteLine("Please, enter worker's position");
                    string position = Console.ReadLine();

                    Console.WriteLine("Please, enter the year of job placement");
                    string line = Console.ReadLine();
                    Console.WriteLine();

                    uint jobPlacementYear;
                    try
                    {
                        jobPlacementYear = Convert.ToUInt32(line);
                    }
                    catch (OverflowException oe)
                    {
                        Console.WriteLine(oe.Message);
                        continue;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }

                    try
                    {
                        workers.AddWorker(new Worker(name, position, jobPlacementYear));
                    }
                    catch (WrongYearFormatException e)
                    {
                        Console.WriteLine(e.Message, Environment.NewLine);
                        continue;
                    }

                    ready = true;
                }

            }
            Console.WriteLine();
        }

        static void DisplayAllWhosExperienceIsBigger(WorkersDataStorage workers, uint experience)
        {
            foreach (Worker worker in workers.FindAllWhosExperienceIsBigger(experience))
            {
                Console.WriteLine(worker.Name);
            }
        }

        static void Main(string[] args)
        {
            WorkersDataStorage workers = new WorkersDataStorage();
            FillArrayFromShell(workers);

            Console.WriteLine("Please, enter the years of experience");

            try
            {
                uint experience = Convert.ToUInt32(Console.ReadLine());
                DisplayAllWhosExperienceIsBigger(workers, experience);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
