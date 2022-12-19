using System;
using System.Text;

namespace typing_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "!@#$%^&*()_+[]{}\\|;:'\",<.>/?";
            Random r = new Random();
            Console.WriteLine();
            StringBuilder sbInput = new StringBuilder();
            for(int j=0; j<input.Length; j++){
                int idx = r.Next()%input.Length;
                sbInput.Append(input[idx]);
            }

            Console.WriteLine(sbInput);
            string user = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            int i=0;
            while(i<user.Length){
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

            Console.WriteLine(sb);
        }
    }
}
