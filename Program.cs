internal class Program
{
    private static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        data.DapatkanNilaiTerbesar(10, 30, 22);
    }
}

class PemrosesData  { 
    public void DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
    {
        dynamic temp1 = data1, temp2 = data2, temp3 = data3;
        if (temp1 > temp2 && temp1 > temp3)
        {
            Console.WriteLine(temp1);
        }
        else if (temp1 < temp2 && temp2 > temp3)
        {
            Console.WriteLine(temp2);
        }
        else {
            Console.WriteLine(temp3);
        }

    }
}