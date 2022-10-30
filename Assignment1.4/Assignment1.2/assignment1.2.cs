using System;

namespace Assignment1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] mark = { 45, 78, 65, 58, 82};
            
            float highest = 0;
            for ( int i = 0; i <=4; i++)
            {
               
                if (mark[i] > highest)
                    highest = mark[i];
            }
            Console.WriteLine(highest);
          
            
        }
    }
}
