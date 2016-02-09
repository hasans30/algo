using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class BingSpellCorrection
    {
        static int nPos = 0;
        public static void CallPossibleSpells()
        {
             //*
             //* "c a s e",0
             //* 
             //*  spellcorrection(char [] a, int nextchar)
             //*  {
             //*   if we reach nextchar>a.length
             //*      return;
             //*    for each p in possibility(a[nextchar])
             //*         return p + spellcorrection(a,nextchar+1);
             //* 
             //* }
             //* /
            /*
             * char [] possibility(char)
             * {
             * //for not a or z  
             * new char [] { char-1,char, char+1}
             * //for a 
             * new char [] {a,b}
             * //for z
             * new char [] {y,z}
             * }
             */

            
            char[] c = new char[] { 'c', 'a', 's', 'e' };
            char[]  result = new char[c.Length];
            SpellCorrection(c,result, 0);
            Console.WriteLine("total={0}", nPos);

        }


        static void SpellCorrection(char [] a, char [] result, int nextchar)
        {

            if (nextchar >= a.Length)
            {
                Console.Write("{0}:",++nPos);
                for(int i=0;i<result.Length;i++)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine();
                return ;

            }
            foreach(var p in Possibility(a[nextchar]))
            {
                //return { new char []{p} + SpellCorrection(a, nextchar + 1)};
                result[nextchar] = p;
                SpellCorrection(a, result, nextchar + 1);


            }

        }

        static char [] Possibility(char c)
        {
            //handle capital
            bool orig = char.IsUpper(c);
            char org = c;
            c = char.ToLower(c);

            if (c=='a')
            {
                if(orig==true)
                {
                    return new char[] { 'A', 'B' };
                }
                return new char[] { 'a', 'b' };
            }
            else if(c=='z')
            {
                if(orig==true)
                {
                    return new char[] { 'Y', 'Z' };
                }
                return new char[] { 'y', 'z' };
            }

            if (orig == true)
                return new char[] { (char)((int)c - 1 + (int)'A'), c, (char)((int)c + 1+(int)'A') };
            return new char[] { (char )((int)c - 1), c, (char)((int)c + 1) };
        }



    }
    
}
