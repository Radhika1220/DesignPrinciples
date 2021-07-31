using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples
{
    public interface IPrintContent
    {
        void PrintContent();
    }
    public interface  IPhotoCopyContent
    {
        void PhotoCopyContent();
    }
    public interface IPrintDuplex
    {
        void PrintDuplexContent();
    }
}
