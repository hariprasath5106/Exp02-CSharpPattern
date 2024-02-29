using System;
public class Pattern
{
    public static void Main()
    {
        // type the code here
        int row;
        row=Convert.ToInt32(Console.ReadLine("Enter the number of rows: "));
        for (int i=0;i<row;i++)
        {
            for (int s=0;s<row-i;s++)
                Console.Write(" ");
                for (int j=0;j<=i;j++)
                {
                    if (int==0 || j==0)
                        c=1; 
                    else
                        c=c*(i-j+1)/j;
                        Console.WriteLine(c+" ");
                }
        }
    }
}