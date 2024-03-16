internal class Program
{
    private static void Main(string[] args)
    {
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