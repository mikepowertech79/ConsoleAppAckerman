using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAckerman
{
    class Program
    {
        static void Main(string[] args)
        {

                for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    Console.WriteLine($"ackerman ({i},{j}) is:{ack(i, j)}");
                Console.ReadLine();
        

        }

        static int ack(int m, int n)
        {
            int answer;
            if (m == 0) answer = n + 1;
            else if (n == 0) answer = ack(m - 1, 1);
            else answer = ack(m - 1, ack(m, n - 1));
            return answer;
        }
    }
}
