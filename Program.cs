using System.Diagnostics;
using System;
using System.Text;

namespace typing_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "!@#$%^&*()_+[]{}\\|;:'\",<.>/?";
            int cnt = input.Length;
            if(args.Length!=0){
                cnt = Convert.ToInt32(args[0]);
            }

            Random r = new Random();
            Console.WriteLine();
            StringBuilder sbInput = new StringBuilder();
            for(int j=0; j<cnt; j++){
                int idx = r.Next()%input.Length;
                sbInput.Append(input[idx]);
            }
            Console.WriteLine(sbInput);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            string user = Console.ReadLine();
            sw.Stop();

            StringBuilder sb = new StringBuilder();
            int i=0;
            while(i<user.Length && i<sbInput.Length){
                if(user[i] == sbInput[i]){
                    i++;
                    continue;
                }
                sb.Append(sbInput[i]);
                i++;
            }
            while(i<sbInput.Length){
                sb.Append(sbInput[i]);
                i++;
            }

            Console.WriteLine($"Typos: {sb}");
            Console.WriteLine($"Total Time: {sw.ElapsedMilliseconds/1000} seconds");
        }
    }
}
