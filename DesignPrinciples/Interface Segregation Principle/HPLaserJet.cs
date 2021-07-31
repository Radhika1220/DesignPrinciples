using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
   public  class  HPLaserJet : IPrintContent, IPrintDuplex
    {
        public void PrintContent()
        {
            Console.WriteLine("\nPrint Content Data of HPLaser");
        }
        public void PrintDuplexContent()
        {
            Console.WriteLine("\nPrint Duplex Content Data of HPLaser");
        }
    }
}
