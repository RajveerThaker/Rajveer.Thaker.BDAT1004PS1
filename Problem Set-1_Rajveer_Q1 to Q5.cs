string name = "Supercalifragilisticexpialidocious";
int nameLength = name.Length;
Console.WriteLine("The name " + name + " contains " + nameLength + " Letters.");

Console.WriteLine(name.Contains("ice"));


string[] words = {"Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus","Bababadalgharaghtakamminarronnkonn"};
string word = "";
int ctr = 0;
foreach (String s in words)
{
    if (s.Length > ctr)
    {
        word = s;
        ctr = s.Length;
     }
}
Console.WriteLine(word +" is the longest word which Contains "+ ctr+ " Letters");


using System;

public class Area
{
    static double triangleArea(int a, int b, int c)
    {
        float s = (a + b + c) / 2;
        return (double)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public static void Main()
    {
        Console.WriteLine("Area is " + triangleArea(2, 2, 2));
    }
}

using System;  
public class 
{  
    public static void Main() 
 {
    int[] arr1 = new int[10];
    int[] arr2 = new int[10];
    int[] arr3 = new int[10];
    int i,j=0,k=0,n;


       Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");
       Console.Write("------------------------------------------------------\n");

       Console.Write("Input the number of elements to be stored in the array :");
       n = Convert.ToInt32(Console.ReadLine());
   
       Console.Write("Input {0} elements in the array :\n",n);
       for(i=0;i<n;i++)
            {
                 Console.Write("element - {0} : ",i);
                  arr1[i] = Convert.ToInt32(Console.ReadLine());   
            }

            for(i=0;i<n;i++)
            {
                if (arr1[i]%2 == 0)
            {
               arr2[j] = arr1[i];
               j++;
            }
            else
            {
              arr3[k] = arr1[i];
               k++;
            }
    }

    Console.Write("\nThe Even elements are : \n");
    for(i=0;i<j;i++)
    {
        Console.Write("{0} ",arr2[i]);
    }

    Console.Write("\nThe Odd elements are :\n");
    for(i=0;i<k;i++)
    {
        Console.Write("{0} ", arr3[i]);
    }
    Console.Write("\n\n");	
   }
 }

using System;
public class Check
{
    static bool inside(int x, int y, int x1, int y1, int x2, int y2)
    {
        if (x > x1 && x < x2 && y > y1 && y < y2)
            return true;
        else
            return false;
    }
    public static void Main()
    {
            int x = 1, y = 1, x1 = 0, y1 = 0, x2 = 2, y2 = 3;
        if (inside(x, y, x1, y1, x2, y2))
            Console.Write("Given point lies inside");
        else
            Console.Write("Given point lies outside");
    }
}

using System;
public class Check
{
    static bool inside(double x, double y, double x1, double y1, double x2, double y2)
    {
        if (x > x1 && x < x2 && y > y1 && y < y2)
            return true;
        else
            return false;
    }
        public static void Main()
        {
            double x = 1, y = 1, x1 = 0.3, y1 = 0.5, x2 = 1.1, y2 = 0.7;
            if (inside(x, y, x1, y1, x2, y2))
                Console.Write("(1,1) Given point lies inside (0.3, 0.5 1.1, 0.7)\n");
            else
                Console.Write("(1,1) Given point lies outside (0.3, 0.5 1.1, 0.7)\n");
            
            if (inside(1, 1, 0.5, 0.2, 1.1, 2))
                Console.Write("(1,1) Given point lies inside (0.5, 0.2, 1.1, 2)");
            else
                Console.Write("(1,1) Given point lies outside (0.5, 0.2, 1.1, 2)");
        }
}


