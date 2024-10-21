using W4_Constructor;

internal class Program
{
    private static void Main(string[] args)
    {
        // create two different baby objects with different constructor calls
        Baby baby1 = new Baby();
        baby1.FirstName = "Bradley";
        baby1.LastName = "Cooper";
        baby1.Introduce();

        Baby baby2 = new Baby("Alice", "Smith");
        baby2.Introduce();
    }
}