using System;
class Pro
{
    static void Multiple(int n,out double percentage,out int H_marks)
    {
        int[] marks=new int[n];
        double sum = 0;
        
        for (int i=0; i<marks.Length; i++)
        {
            Console.WriteLine("enter the marks of {0} subject:",i);
            marks[i]=int.Parse(Console.ReadLine());
        }
         H_marks=marks[0];
        for(int j=0; j<marks.Length; j++)
        {
            sum+=marks[j];
            if(marks[j]>H_marks)
            {
                H_marks =marks[j];
            }
        }
        percentage = (sum / (n * 100)) * 100;

    }
    static void Main()
    {
        Console.WriteLine("enter your subjects:");
        int n=int.Parse(Console.ReadLine());
       int H_marks;
        double percentage;
        Multiple(n,out percentage,out H_marks);
        Console.WriteLine("highest marks are:"+H_marks);
        Console.WriteLine("your percentage is:"+percentage);
    }

}
