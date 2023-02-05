using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
internal class Program
{
    static void Main(string[] args)
    {
        int n, m, xn, yn, zn, k, s;
        string a;
        string[] o = Console.ReadLine().Split();
        n = Convert.ToInt32(o[0]);
        m = Convert.ToInt32(o[1]);
        o = Console.ReadLine().Split();
        xn = Convert.ToInt32(o[0]);
        yn = Convert.ToInt32(o[1]);
        zn = Convert.ToInt32(o[2]);
        for (int i = 0; i< m;i++)
        {
            o = Console.ReadLine().Split();
            a = o[0];
            k = Convert.ToInt32(o[1]);
            s = Convert.ToInt32(o[2]);
            int x = xn, y = yn, z = zn;
            if (a == "X")
            {
                if (xn == k)
                {
                    if (s==1)
                    {
                        z = n - yn + 1;
                        y = zn;
                    }
                    else
                    {
                        z = yn;
                        y = n - zn + 1;

                    }
                }
                zn = z;
                yn = y;
            }
            if (a == "Y")
            {
                if (yn == k)
                {
                    if (s == 1)
                    {
                        z = n - xn + 1;
                        x = zn;
                    }
                    else
                    {
                        z = xn;
                        x = n - zn + 1;

                    }
                }
                zn = z;
                xn = x;
            }
            if (a == "Z")
            {
                if (zn == k)
                {
                    if (s == 1)
                    {
                        y = n - xn + 1;
                        x = yn;
                    }
                    else
                    {
                        y = xn;
                        x = n - yn + 1;

                    }
                }
                xn = x;
                yn = y;
            }
        }
        Console.WriteLine("{0} {1} {2}",xn,yn,zn);
    }
}
