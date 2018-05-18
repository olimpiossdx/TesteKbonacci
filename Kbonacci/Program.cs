using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knbonacci
{
    public class Kbonacci
    {
        public int k, n;
        public static long aux;
        public static long[] vector;

        public Kbonacci(int k)
        {
            vector = new long[k];
            for (int i = 0; i < k; i++)
                vector[i] = 1;
        }
        public static long Kcalculo(int n, int k)
        {
            aux = 0;
            int f = 0;
            for (int i = 0; i <= (n - k); i++)
            {
                aux = 0;
                for (int j = 0; j < k; j++)
                    aux += vector[j];
                f = i % k;
                vector[f] = aux;
            }

            return (vector[f]);
        }

        public static long KbonacciFaster(int k, int n)
        {
            long aux1, aux2, aux3;

            aux1 = (long)Math.Pow(2, n + k);
            aux2 = (long)(Math.Pow(aux1, k)) + (long)Math.Truncate(-Math.Pow(aux1, k) / (aux1 - 1));
            //decimal.Truncate((long)(Math.Pow(aux1, k) / (aux1 - 1)))
            //aux2 =(long)((long) -  r1 );
            aux3 = (long)((Math.Pow(aux1, n + k) % aux2) % aux1);

            //r1 = (long)((k+ Math.Sqrt( (k*k)+4))/2);
            //r2 = (long)((k - Math.Sqrt((k * k) + 4)) / 2);
            //aux3 = (long)(Math.Pow(r1, n)- (-Math.Pow(r1,-n)) / (r1+ Math.Pow(r1, -n)));

            return (aux3);

        }

        static void Main(string[] args)
        {
            //Console.Write("Informe o numero para cálculo k-zueira->");
            int k = 5;//= Convert.ToInt32(Console.ReadLine());
            int n = 30;//= Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 7; i++)
            //{
            //  Console.Write(i + "     ");
            //}


            Console.ReadKey(true);
        }
    }
}
