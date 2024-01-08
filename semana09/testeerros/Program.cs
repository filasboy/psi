using System;

namespace testeerros
{
    class Program
    {
        static void Main(string[] args)
        {
          int i = 0;
          Console.WriteLine("Insere um número inteiro: ");
            try 
           {
           
                // Código perigoso que pode lançar exceções
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                // Código para tratar exceção
                 Console.WriteLine("Ocorreu o seguinte problema: " + e.Message);
      
            }   

              Console.WriteLine($"Número inserido: {i}");
        }
    }  
}
