internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Rafli");
    }
}

public class HaloGeneric
{
    public static void SapaUser(String X)
    {
        Console.WriteLine("Halo user "+ X);
    }
}