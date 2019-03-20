using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            String[] validWords = new String[] { "a", "bb", "ab", "bbb", "bab", "bbbb" };

            WordBuilder wb = new WordBuilder(validWords);
            wb.longestSet(wb.validWords);

            String[] valid = new String[] { "c", "bb", "ab", "bbb", "bab", "bbbb" };

            WordBuilder w = new WordBuilder(valid);
            wb.longestSet(w.validWords);

           
        }
      
    }
}
