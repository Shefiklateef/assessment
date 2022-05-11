using System.Net.Security;
using System.Collections.Generic;
using System;

namespace code_challenge_lateef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string ne="twale";
            string nr="e";
            Console.WriteLine(ne.Remove());
            // string num1="what goes around comes around";
            // string num2="a";
            // Remove(num1,num2);
            string line="";
            Console.WriteLine("enter largest word");
            string[] word=line.Split(new[]{""},StringSplitOptions.None);
            int sum=0;
            foreach (string s in word)
            {
                if (s.Length>sum)
                {
                    word=s;
                    sum=s.Length;
                }
            }

        
            
        }
        static void Attendance(char[]num)
        {
            int count1=0;
            int count=0;
            int count2=0;
          for (int i = 0; i <num.Length; i++)
          {
              if (num[i]=='a')
              {
                  
              }
               if (num[i]=='A')
              {
                  count1++;
              }
              if (num[i]=='L')
              {
                  count2++;
              }
              if (num[i]=='P')
              {
                  count++;
              }
              if (count1<2&&count<3)
              {
                  Console.WriteLine("false");
              }
              if (count1>2&&count>3)
              {
                  Console.WriteLine("true");
              }
          }

        }
        static void Remove(string e,string f)
        {
            Console.WriteLine(e.Replace(f,""));
        }
    
    }
}

            
       
         
            




