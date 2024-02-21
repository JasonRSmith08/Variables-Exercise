namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string petName = " Charlie ";

            int petAge = 11;

            char firstInitial = 'C';

            bool isBrown = false;

            double petWeight = 70;

            decimal petHeight = 37.6m;

            Console.WriteLine($"Hello. My pets name is {petName}, his initial is {firstInitial}, and he is {petAge} years old.");
            Console.WriteLine($"My pet weighs {petWeight} pounds, and he is {petHeight} inches tall.");
            Console.WriteLine($"It is {isBrown.ToString().ToLower()} he is not the color brown.");


        }
    }
}
