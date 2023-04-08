using System;
using System.Collections.Generic;

namespace algoritma11
{
    class Program
    {
        static string[] hash = new string[32];
        


        static int hf(string text)
        {
            int a = 0;
            for (int i = 0; i < text.Length; i++)
            {
                a += (byte)text[i];
            }
            //  return a % hash.Length;
            return a & 0x1f;
        }
        static void hashInsert(string text)
        {
            // dolu ise boş yer aranacak
            int indis = hf(text);
            if (hash[indis] == "")
            {
                hash[hf(text)] = text;
            }
            else
            {  
                for ( indis = indis+1; indis < hash.Length; indis++)
                {
                    if (hash[indis] == "") 
                    { 
                        hash[indis] = text; 
                        break; 
                    }
                }
            }
        }
        static bool hashSearch(string text)
        {

            // return hash[hf(text)] == text ? true : false;
            int indis = hf(text);

            if (hash[indis] == text) 
            {
                return true;
            }               
            else
            {
                for  (indis = indis + 1; indis < hash.Length; indis++)
                {
                    if (hash[indis] == text) return true;
                }
            }

            return false;
        }
        static void hashDelete(string text)
        {
            int indis = hf(text);
            if (hash[hf(text)] == text)
            {
                hash[hf(text)] = "";
            }
            for ( indis = indis+1; indis < hash.Length; indis++)
            {
                if (hash[indis] == text) 
                { 
                    hash[hf(text)] = "";
                    break; 
                }
            }

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < hash.Length; i++)
            {
                hash[i] = "";
            }

        }
    }
}
