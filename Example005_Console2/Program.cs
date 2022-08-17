// Увеличение ширины буфера консоли до 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace GFG {
  
class Program {
  
    static void Main(string[] args)
    {
  
        // Display current Buffer Width
        Console.WriteLine("Default Buffer Width: {0}",
                                 Console.BufferWidth);
  
        // Set the Buffer Width to 100
        Console.BufferWidth = 100;
  
        // Display current Buffer Width
        Console.WriteLine("Changed Buffer Width: {0}",
                                 Console.BufferWidth);
    }
}
}
