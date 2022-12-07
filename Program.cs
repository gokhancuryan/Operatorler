using System;

namespace operatorler
{
    class Program
    {
        static void Main(String[] args)
        {
           // Atama ve İşlemli Atama
            int x = 3;
            int y = 3;
            y += 2;
            y/= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal Operatörler
            // ||(veya) , &&, !

            bool isSuccess = true; 
            bool isCompoleted = false;

            if(isSuccess && isCompoleted) //ve her iki koşuluda true ister. 
                Console.WriteLine("Perfect");  
            
            if(isSuccess || isCompoleted) //ve  
                Console.WriteLine("Perfekto");
            
            if(isSuccess && !isCompoleted) // isSuccess ise fakat isCompleted değil ise.
                Console.WriteLine("Fine");

                // İlişkisel Operatörler 
                // <, >, <= =>, ==, =!,

            int a = 5;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);


            // Aritmetik Operatörler

            // / * % + - 

            


        }
    }
}
