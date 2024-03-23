// See https://aka.ms/new-console-template for more information

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
    {
        dynamic a = input1;
        dynamic b = input2;
        dynamic c = input3;

        return a+ b + c; 
    }
}

class program
{
    static void main(String[] args)
    {
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 02, 22));
    }
}