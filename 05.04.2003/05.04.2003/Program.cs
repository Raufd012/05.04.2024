namespace _05._04._2003
{
    internal class Program
    {
        static void Main(string[] args)



        {
            //task1

            //    StudentRecord std1 = new StudentRecord()
            //    {
            //        Name = "Ulvi",
            //        Surname = "Abdullazada",
            //        Age = 24,
            //        Group = "AB106",
            //        Uni = "AzTU"
            //    };
            //    StudentRecord std2 = std1 with { Name = "Rauf", Surname = "Dostuyev" };
            //    Console.WriteLine(std1);
            //    Console.WriteLine(std2);
            //}
            //record StudentRecord(string Name = "XXX", string Surname = "YYY", int Age = 0, string Group = "", string Uni = "");


            //animal task


            Bird quw = new Parrot();
            Shark akula = new Shark() { Name = "Elxan" };
            Eagle eagle = new Eagle() { Name = "Sahib" };
            Animal[] animals = { quw, akula, eagle };

            Bird[] birds = { quw, eagle, new Penguin() };
            quw.Eat();

            quw.Fly();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
            quw.Talk();
            Console.WriteLine(quw);
            quw.Fly();
        }
    }
}