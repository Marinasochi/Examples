// Увеличение высоты буфера консоли на 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace GFG {
  
class Program {
  
    static void Main(string[] args)
    {
  
        // Display current Buffer Height
        Console.WriteLine("Default Buffer Height: {0}",
                                 Console.BufferHeight);
  
        // Set the Buffer Height to 100
        Console.BufferHeight = 100;
  
        // Display current Buffer Height
        Console.WriteLine("Changed Buffer Height: {0}",
                                 Console.BufferHeight);
    }
}
}
