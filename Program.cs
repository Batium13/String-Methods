using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz!";
            string degisken2 = "CSharp";
            // Lenght
            Console.WriteLine(degisken.Length);
            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            
            //Concat
            Console.WriteLine(string.Concat(degisken," Merhaba!"));
            
            //Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,true));  //Büyük Küçük harf duyarlı değildir.
            Console.WriteLine(string.Compare(degisken,degisken2,false)); //Büyük Küçük harf duyarlı olur.

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Batuhan"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba ! "));

            //PadLeft, PadRight
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);
            
            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //SubString
            Console.WriteLine(degisken.Substring(4)); // 4. indexten sonraki karakterleri getirir
            Console.WriteLine(degisken.Substring(4,6));//4. karakterden sonraki 6 karakteri getirir.
            

            
        }
    }
}
