//print all asscii VALUE
/*using System;

class Program
{
    static void Main(string[] args)
    {
        
        for (int i=0; i<=255; i++)
        {
            char ch = Convert.ToChar(i);
            Console.WriteLine(ch +" "+ i);
        }
        Console.ReadLine();
    }
}*/


//Print A to Z
/*using System;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 65; i <= 90; i++)
        {
            char ch = Convert.ToChar(i);
            Console.WriteLine(ch + " " + i);
        }
        Console.ReadLine();
    }
}*/


//print D asscii value
/*using System;

class Program
{
    static void Main(string[] args)
    {
        char str = 'D';
        int ascii = str;
            Console.WriteLine(ascii);
        
        Console.ReadLine();
    }
}*/


//print all asscii value using do-while loop
/*
using System;

class Program
{
    static void Main(string[] args)
    {

        int i = 0;
        do
        {
            char ch = Convert.ToChar(i);
            Console.WriteLine(ch + " " + i);

            i++;
        }
        while (i<= 255);
        {

        }
        Console.ReadLine();
    }
}*/


//print a string using foreeach loop
/*
using System;

class Program
{
    static void Main(string[] args)
    {
      
        string s = "3rffgfghbaADFHH";
        byte[] ASCII =Encoding.ASCII.GetBytes(s);
        
        foreach( byte b in ASCII  ) 
        {
            
            Console.WriteLine(b);
           
        }
        Console.ReadLine();
    }//doubt
}*/

//print all asscii value using while loop
/*using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while(i<=255)
        {
            char ch = Convert.ToChar(i);
            i++;
            Console.WriteLine(ch + " " + i);
        }
        Console.ReadLine();
    }
}*/

//write a program using asscii value using foreach loop, asked the value from the user
/*using System;

class Program
{
    static void Main(string[] args)
    {
        string str;

            Console.WriteLine("enter the alphabet or any sentence: ");
        str = Console.ReadLine();
        foreach (char ch in str)
        {
            Console.WriteLine((int) ch);
            //Console.Write((int)ch);
        }
        
        Console.ReadLine();
    }
}*/

//w.t.p and print your name(alphabet) and show the asscii value in each alphabet 
/*
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        string str = "sonam";
        for (int i = 0; i < str.Length; i++)


        {

            // Convert the string into a byte[].
            byte[] number = Encoding.ASCII.GetBytes(str);

            //byte[] number = Convert.ToByte(str);dobut

            Console.WriteLine(str.Substring(i, 1) + " as ASCII value of: " + number[i]);

           //Console.WriteLine(str +" "+ i);
        }

        Console.ReadLine();
    }
}*/

//w.t.p that user enter the alphabet and get the result as asscii value

/*using System;

class Program
{
    static void Main(string[] args)
    {
        char ch;

        Console.WriteLine("enter the alphabet or any sentence:");

        ch = char.Parse(Console.ReadLine());
        if(ch>=65 && ch<=90)
        {
            ch++;
            Console.Write(ch);
        }
        Console.ReadLine();
    }
}
*/