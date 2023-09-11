internal class Program
{
    private static void Main(string[] args)
    {
        string? input = string.Empty;
        int num = 0;
        
        WriteLine("Escriba el tamaño de arreglo");
        try
        {
            input = ReadLine();
            num = int.Parse(input);
             
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }
        WriteLine();

        int[] arr = new int[num];
        if(num%2==0)
        {
            for (var i = 0; i < num / 2; i++)
            {
                arr[i] = i + 1;
                arr[^(i + 1)] = -i -1;
            }
        }else
        {
            for (var i = 0; i < num / 2; i++)
            {
                arr[i] = i + 1;
                arr[^(i + 2)] = -i -1;
            }
            arr[^1] = 0;
        }

        foreach (var item in arr)
        {
            WriteLine(item);
        }
    }
}