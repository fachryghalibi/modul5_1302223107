// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Collections.Generic;



    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 02, 22));
            SimpleDataBase<double> DB = new SimpleDataBase<double>();
            DB.AddNewData(13);
            DB.AddNewData(02);
            DB.AddNewData(22);
            DB.printAllData();
        }
    }

    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic a = input1;
            dynamic b = input2;
            dynamic c = input3;

            return (a + b + c);
        }
    }



    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T newData)
        {
            this.storedData.Add(newData);
            this.inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < this.inputDates.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi " + this.storedData[i] + " pada waktu UTC " + this.inputDates[i]);
            }
        }

    }


