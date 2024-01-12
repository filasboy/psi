using System;
using System.IO;
using System.IO.Compression;
namespace descomprosor
{
    class Program
    {
        static void Main(string[] args)
        {
            string ficheiro = "ficheiro.txt.gz" ;
            comprime(ficheiro);
          }
        private static void comprime(string ficheiro)
        {
          string line;

          FileStream fs = new FileStream(ficheiro, FileMode.Create, FileAccess.Write);
          
          GZipStream gzs = new GZipStream(fs, CompressionLevel.Optimal);
          
          StreamWriter sw = new StreamWriter(gzs);
          
          while ((line = Console.ReadLine()).Length > 0)
          {
              sw.WriteLine(line);
          }
          
          sw.Close();

        }
        private static void descomprime(string ficheiro)
        {
          
        }
  
   }
}