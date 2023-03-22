namespace LINQITöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Töö");
            Console.WriteLine("Aggregate LINQ");
            //Meetodite välja kutsumine
            AggregateLINQ();
            MaxLINQ();

        }

        public static void AggregateLINQ()
        {
            //Seda kasutatakse mitme rea väärtuste rühmitamiseks sisendiks ja 
            //väljundi tagastamiseks ühe väärtusena
            string commaSeparatedPersonNames = PeopleList.peoples
                .Aggregate<People, string>(
                "People names: ",
                (str, x) => str += x.Name + ", "
                );

            Console.WriteLine(commaSeparatedPersonNames);
        }



        public static void MaxLINQ()
        {
            //Valib kollektsioonist suurima numbri
            Console.WriteLine("Max LINQ");

            int[] intNumbers = new int[] { 31, 21, 18, 20, 19, 40, 23 };
            //Using Method Syntax
            int MSLergestNumber = intNumbers.Max();
            //Using Query Syntax
            int QSLergestNumber = (from num in intNumbers
                                   select num).Max();
            Console.WriteLine("Vanim inimene = " + MSLergestNumber);
        }
    }
}