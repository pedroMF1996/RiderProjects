using System;
using System.Collections.Generic;

namespace Prova1POOex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sr = new[] {s.ToLower()};
            
            //a - 97
            //z - 122
            List<string> letra = new List<string>();
            foreach (var x in sr)
            {
                letra.Add(x);
            }

            int a= 0, b = 0, c= 0, d= 0, e= 0, f= 0, g= 0, h= 0, ii= 0, j= 0, k= 0, l= 0, m= 0, n= 0, o= 0, p= 0, q= 0, r= 0, ss= 0, t= 0, u= 0, v= 0, w= 0, xx= 0, y= 0, z = 0;
            for (int i = 97; i < 122; i++)
            {
                if (i==97)
                {
                    a = 1;
                }else if(i==98)
                {
                    b += 1;
                }if (i==99)
                {
                    c += 1;
                }if (i==100)
                {
                    d += 1;
                }if (i==101)
                {
                    e += 1;
                }if (i==102)
                {
                    f += 1;
                }if (i==103)
                {
                    g += 1;
                }if (i==104)
                {
                    h += 1;
                }if (i==105)
                {
                    ii += 1;
                }if (i==106)
                {
                    j += 1;
                }if (i==107)
                {
                    k += 1;
                }if (i==108)
                {
                    l += 1;
                }if (i==109)
                {
                    m += 1;
                }if (i==110)
                {
                    n += 1;
                }if (i==111)
                {
                    o += 1;
                }if (i==112)
                {
                    p += 1;
                }if (i==113)
                {
                    q += 1;
                }if (i==114)
                {
                    r += 1;
                }if (i==115)
                {
                    ss += 1;
                }if (i==116)
                {
                    t += 1;
                }if (i==117)
                {
                    u += 1;
                }if (i==118)
                {
                    v += 1;
                }if (i==119)
                {
                    w += 1;
                }if (i==120)
                {
                    xx += 1;
                }if (i==121)
                {
                    y += 1;
                }if (letra.Contains(i))
                {
                    z += 1;
                }
            }
            

        }
    }
}