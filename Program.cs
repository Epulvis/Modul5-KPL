using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(12);
        data.AddNewData(34);
        data.AddNewData(56);
        data.AddNewData(10);
        data.AddNewData(30);
        data.AddNewData(22);
        data.PrintAllData();   
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData() {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine($"Data {i+1} berisi: {storedData[i]}, yang pada disimpan waktu UTC: {inputDates[i]}");
        }
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