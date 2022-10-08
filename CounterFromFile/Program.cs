using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    struct Users // структура для работы с обобщенным списком
    {
        public string kilometrs; 
        public string metrs;
        public string mils;
        public string futs;
        public string yards;
        public string dyims;
        public string versts;




        public void show() // метод для вывода в консоль экземпляра структуры
        {
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15} {6,-15} ", kilometrs, metrs, mils, futs, yards, dyims, versts);
        }
        public string concatKmMets(List<double> listOne, List<double> listTwo, List<double> listItog, string one, string two, string itog) // метод для представления экземпляра структуры в виде текстовой строки с разделителем ;
        {
            return "из" +";"+ listOne + ";" + one + ";" + "в" +";" +  listTwo + ";" + two + ";" + "получится" +";"+ listItog + ";" + itog ;
        }
    }
internal class Program
{

        public static List<double> kmMetOnMils = new List<double>();
        public static List<double> kmMetOnFuts = new List<double>();
        public static List<double> kmMetOnYards = new List<double>();
        public static List<double> kmMetOnDyim = new List<double>();
        public static List<double> kmMetOnVersts = new List<double>();
        public static List<double> km = new List<double>();
        public static List<double> met = new List<double>();
        public static List<double> futsList = new List<double>();
        public static List<double> futsOnKm = new List<double>();
        public static List<double> futsOnMet = new List<double>();
        public static List<double> milsList = new List<double>();
        public static List<double> milsOnKm = new List<double>();
        public static List<double> milsOnMet = new List<double>();
        public static List<double> yardsList = new List<double>();
        public static List<double> yardsOnKm = new List<double>();
        public static List<double> yardsOnMet = new List<double>();
        public static List<double> diymList = new List<double>();
        public static List<double> diymOnKm = new List<double>();
        public static List<double> diymOnMet = new List<double>();
        public static List<double> verstList = new List<double>();
        public static List<double> verstOnKm = new List<double>();
        public static List<double> verstOnMet = new List<double>();
        static void clearList(List<Users> L) // перед созданием  и заполнением нового списка применить данный метод
        {
            kmMetOnMils.Clear();
            kmMetOnFuts.Clear();
            kmMetOnYards.Clear();
            kmMetOnDyim.Clear();
            kmMetOnVersts.Clear();
            km.Clear();
            met.Clear();
            futsList.Clear();
            futsOnKm.Clear();
            futsOnMet.Clear();
            milsList.Clear();
            milsOnKm.Clear();
            milsOnMet.Clear();
            yardsList.Clear();
            yardsOnKm.Clear();
            diymList.Clear();
            diymOnKm.Clear();
            diymOnMet.Clear();
            verstList.Clear();
            verstOnKm.Clear();
            verstOnMet.Clear();
           
        }
        static void printFound()
        {
            for(int i =0; i < kmMetOnMils.Count;i++)
            {
                Console.WriteLine($"из {km[i]} км  и  {met[i]} метров в мили: {kmMetOnMils[i]}");
                
            }
            for (int i = 0; i < kmMetOnFuts.Count; i++)
            {
                Console.WriteLine($"из {km[i]} км  и  {met[i]} метров в футы: {kmMetOnFuts[i]}" );

            }
            for (int i = 0; i < kmMetOnYards.Count; i++)
            {
                Console.WriteLine($"из {km[i]} км  и  {met[i]} метров в ярды: {kmMetOnYards[i]}");

            }
            for (int i = 0; i < kmMetOnDyim.Count; i++)
            {
                Console.WriteLine($"из {km[i]} км  и  {met[i]} метров в дюймы: {kmMetOnDyim[i]}");

            }
            for (int i = 0; i < kmMetOnVersts.Count; i++)
            {
                Console.WriteLine($"из {km[i]} км  и  {met[i]} метров в версты:  {kmMetOnVersts[i]}");

            }
            for (int i = 0; i < milsOnMet.Count; i++)
            {
                Console.WriteLine($"из {milsList[i]} миль получится  {milsOnKm[i]}километров    и  {milsOnMet[i]}  метров");
            }
            for (int i =0; i< futsOnMet.Count;i++)
            {
                Console.WriteLine($"из {futsList[i]} футов получится  {futsOnKm[i]}километров    и  {futsOnMet[i]}  метров");
            }
            for (int i = 0; i < yardsOnMet.Count; i++)
            {
                Console.WriteLine($"из {yardsList[i]} ярдов получится  {yardsOnKm[i]}километров    и  {yardsOnMet[i]}  метров");
            }
            for (int i = 0; i < diymOnMet.Count; i++)
            {
                Console.WriteLine($"из { diymList[i]} дюймов получится  { diymOnKm[i]}километров    и  { diymOnMet[i]}  метров");
            }
            for (int i = 0; i < verstOnMet.Count; i++)
            {
                Console.WriteLine($"из {verstList[i]} верст получится  {verstOnKm[i]}километров    и  {verstOnMet[i]}  метров");
            }
           
        }
       static public string concatKmMet(double listOne, double listTwo, double listItog, string one, string two, string itog) // метод для представления экземпляра структуры в виде текстовой строки с разделителем ;
        {
            string iz = "из";
            string poluch = "получиться";
            string and = "и";
            return iz +";"+ listOne + ";" + one + ";"+ poluch + ";" + listTwo + ";" + two + ";"+and  +";" +  listItog + ";" + itog;
        }
        static public string concatOtherEqual(double km,double metrs,double others,string other) // метод для представления экземпляра структуры в виде текстовой строки с разделителем ;
        {
            string iz = "из";
            string poluch = "получиться";
            string and = "и";
            return iz + ";" + km + ";" + "километров" + ";" + and + ";" + metrs + ";" + "метров" + ";" + poluch + ";" + others + ";" + other; 
        }
        static void foundValue(List<Users> L)
    {

           


    foreach (Users u in L)
    {
                double klm = 0;
                double meters = 0;
                double futs = 0;
                double mils = 0;
                double yards = 0;
                double diym = 0;
                double verst = 0;

                try
                {
                    klm = Convert.ToDouble(u.kilometrs);
                   

                }
                
                catch { }
                try
                {
                   
                    meters = Convert.ToDouble(u.metrs);

                }

                catch { }


                if (klm != 0 || meters != 0) 
                
                {
                    km.Add(klm);
                    met.Add(meters);
                    kmMetOnMils.Add((klm * 1000 + meters) / 1609);
                    kmMetOnFuts.Add((klm*1000 + meters)* 3.28084);
                    kmMetOnDyim.Add((klm * 1000 + meters) * 39.3701);
                    kmMetOnYards.Add((klm * 1000 + meters) * 1.09361);
                    kmMetOnVersts.Add((klm * 1000 + meters) / 1067);

                    

                }



                try
                {

                    futs = Convert.ToDouble(u.futs);
                }
                catch { }
                
                

                if (futs != 0) 
               
                {
                    futsList.Add(futs);

                    meters = futs / 3.281;

                    klm = (int)meters / 1000;
                    meters = meters - klm * 1000;
                    meters = Math.Round(meters, 5);

                    futsOnKm.Add(klm);
                    futsOnMet.Add(meters);

                    

                }


                try
                {
                    mils = Convert.ToDouble(u.mils);

                }
                catch { }
                if(mils!=0)
                {
                    milsList.Add(mils);

                    meters = mils * 1609;

                    klm = (int)meters / 1000;
                    meters = meters - klm * 1000;
                    meters = Math.Round(meters, 5);

                    milsOnKm.Add(klm);
                    milsOnMet.Add(meters);


                }

                try
                {
                    yards = Convert.ToDouble(u.yards);

                }
                catch { }
                if (yards != 0)
                {
                    yardsList.Add(yards);

                    meters = yards / 1.094;

                    klm = (int)meters / 1000;
                    meters = meters - klm * 1000;
                    meters = Math.Round(meters, 5);

                    yardsOnKm.Add(klm);
                    yardsOnMet.Add(meters);


                }
                try
                {
                    diym = Convert.ToDouble(u.dyims);

                }
                catch { }
                if (diym != 0)
                {
                    diymList.Add(diym);

                    meters = diym / 39.37;

                    klm = (int)meters / 1000;
                    meters = meters - klm * 1000;
                    meters = Math.Round(meters, 5);

                    diymOnKm.Add(klm);
                    diymOnMet.Add(meters);


                }
                try
                {
                    verst = Convert.ToDouble(u.versts);

                }
                catch { }
                if (verst != 0)
                {
                    verstList.Add(verst);

                    meters = verst * 1066.8;

                    klm = (int)meters / 1000;
                    meters = meters - klm * 1000;
                    meters = Math.Round(meters, 5);

                    verstOnKm.Add(klm);
                    verstOnMet.Add(meters);


                }
            }


    }

    
    static void getData(string path, List<Users> L) // метод для чтения записей из файла
    {
    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.GetEncoding(1251))) // использование  StreaReader для считывания записей из файла в обобщенный список
    {
    while(sr.EndOfStream!=true) // считывание будет производиться до    тех пор, пока не наступит конец файла
    {
    string[] array = sr.ReadLine().Split(';'); // создание массива для разделения одной записи на отдельные элементы
        L.Add(new Users()
          {
          kilometrs = array[0],
          metrs = array[1],
          mils = array[2],
          futs = array[3],
          yards = array[4],
          dyims = array[5],
          versts = array[6]
        }) ;
       }
    }
  }
static void printData(List<Users> L) // метод для вывода данных в консоль
{
    foreach (Users u in L)
    {
        u.show();
    }
           
}
static void inputData(string path, List<Users> L) // статический метод для записи в csv-файл экземпляров структуры
{

    using (StreamWriter sw = new StreamWriter(path, true,System.Text.Encoding.GetEncoding(1251))) // создание StreamWriter для записи в файл, значение второго параметра true необходимо для того, чтобы новые записи были добавлены в конец
    {


                for (int i = 0; i < kmMetOnMils.Count; i++)
                {
                    sw.WriteLine(concatOtherEqual(km[i], met[i], kmMetOnMils[i], "миль"));

                }
                for (int i = 0; i < kmMetOnFuts.Count; i++)
                {
                    sw.WriteLine(concatOtherEqual(km[i], met[i], kmMetOnFuts[i], "фут"));

                }
                for (int i = 0; i < kmMetOnYards.Count; i++)
                {
                    sw.WriteLine(concatOtherEqual(km[i], met[i], kmMetOnYards[i], "ярд"));

                }
                for (int i = 0; i < kmMetOnDyim.Count; i++)
                {
                    sw.WriteLine(concatOtherEqual(km[i], met[i], kmMetOnDyim[i], "дюймов"));

                }
                for (int i = 0; i < kmMetOnVersts.Count; i++)
                {
                    sw.WriteLine(concatOtherEqual(km[i], met[i], kmMetOnVersts[i], "верст"));

                }


                for (int i = 0; i < milsList.Count; i++)
                {
                    sw.WriteLine(concatKmMet(milsList[i], milsOnKm[i], milsOnMet[i], "миль", "километров", "метров"));
                }
                for (int i=0; i < futsList.Count;i++)
                {
                    sw.WriteLine(concatKmMet(futsList[i],futsOnKm[i],futsOnMet[i],"футов","километров", "метров"));
                }
                
                for (int i = 0; i < yardsList.Count; i++)
                {
                    sw.WriteLine(concatKmMet(yardsList[i], yardsOnKm[i], yardsOnMet[i], "ярдов", "километров", "метров"));
                }
                for (int i = 0; i < diymList.Count; i++)
                {
                    sw.WriteLine(concatKmMet(diymList[i], diymOnKm[i], diymOnMet[i], "дюймов", "километров", "метров"));
                }
                for (int i = 0; i < verstList.Count; i++)
                {
                    sw.WriteLine(concatKmMet(verstList[i], verstOnKm[i],verstOnMet[i], "верст", "километров", "метров"));
                }
          
                Console.WriteLine("ЗАписи сделаны");
                Console.ReadKey();
        

    }
}
static void Main(string[] args)
{
    List<Users> counters = new List<Users>(); // создание списка для хранения данных
// вызов метода для записи данных в список:
    
    getData("dataLenght(1).csv", counters);
    // вызов метода для вывода данных в консоль:
    printData(counters);
    foundValue(counters);
    printFound();
    inputData("newDataLenght.csv", counters);
    // создание нового экзампляра структуры:
    
  
}
}
}