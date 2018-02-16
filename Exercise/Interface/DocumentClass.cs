using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Interface
{
   public class DocumentClass:IPrintable,IStorable
    {
        //IPrintable
        public void Print(string display)
        {
            
        }

        public void ExportTo(string write)
        {
            
        }

        //IStorable
        public void Read(string display)
        {
            
        }

        public void Write(string write)
        {
            
        }
    }
}
