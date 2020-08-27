using System;

namespace ItransitionTask3
{
    class Program : Randomizer
    {
        static void Main(string[] args)
        {            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();
            try
            {
                string locale = args[0];
                int quantityRecords;
                double quantityErrors = 0;
                quantityRecords = int.TryParse(args[1], out quantityRecords) ? 
                                    quantityRecords :
                                    throw new ArgumentException("Invalid data");
                if (args.Length == 3) 
                {
                    double.TryParse(args[2], out quantityErrors);
                }

                Person[] people = new Person[quantityRecords];
                Errors.Errors errors = new Errors.Errors(quantityErrors);

                for (int i = 0; i < quantityRecords; i++)
                {
                    bool isMan = random.Next(0, 2) == 1;
                    Generator generator = new Generator(errors);
                    people[i] = generator.GetGeneratePerson(locale, isMan);
                }
                //foreach (var item in people)
                //{
                //    Console.WriteLine(item.FirstName);
                //    Console.WriteLine(item.LastName);
                //    Console.WriteLine(item.Patronymic + ";");
                //    Console.WriteLine(item.ZipCode);
                //    Console.WriteLine(item.Country);
                //    Console.WriteLine(item.City);
                //    Console.WriteLine(item.Street);
                //    Console.WriteLine(item.NumberHome);
                //    Console.WriteLine(item.NumberFlat + ";");
                //    Console.WriteLine(item.Phone);
                //    Console.WriteLine();
                //}
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
