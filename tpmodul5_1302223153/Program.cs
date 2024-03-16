internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric.SapaUser("Rafli");
        DataGeneric<String> NIM = new DataGeneric<String>("1302223153");
        NIM.PrintData();
    }
}

public class DataGeneric<T>
{
    T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

public class HaloGeneric
{
    public static void SapaUser(String X)
    {
        Console.WriteLine("Halo user "+ X);
    }
}