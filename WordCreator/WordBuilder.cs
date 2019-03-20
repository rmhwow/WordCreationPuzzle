using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCreator
{
    class WordBuilder
    {
        public String[] validWords;

        public WordBuilder(String[] valid) {
            this.validWords = valid;
        }
        /*Method to display the list to the user*/
        public void printResults(Stack<String> valid)
        {
            try
            {
                String options = null;

                foreach (String s in valid)
                {
                    options += s + ", ";
                }
                String finalopt = options.Remove(options.LastIndexOf(','), 1);
                Console.WriteLine("The longest valid set  is { " + finalopt + "}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Sorry there are no valid words");
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        /*Method to determine the shortest word within the list.  I made the assumption that we have to first start with the shortest word on the list.  
          This logic could change if we decided it needed to be the shortest word with the most potential words to build
         */
        public String shortestBuildWord(string[] words) {
            String shortW = null;
            for (int i = 0; i < words.Length; i++)
            {
                if (shortW == null)
                {
                    shortW = words[i];
                }
                else if (shortW.Length > words[i].Length)
                {
                    shortW = words[i];
                }
            }

            return shortW;
        }

  
        /* determines the longest set of legitimate words from the shortest word then calls the printResults method to display */
        public void longestSet(string[] words)
        {
           
            Stack<String> valid = new Stack<String>();
            String shortW = shortestBuildWord(words);


            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(shortW) && words[i].Length >= 1)
                {
                    if (containsOnce(words[i], shortW))
                    {
                        valid.Push(words[i]);
                    };
                }
            }


           printResults(valid);

        }
        //Making the assumption that the shortest word shouldn't appear in a word more than once aka "bab" is okay but not "baba"
        Boolean containsOnce(String s, String sub)
        {
            int i = s.IndexOf(sub);
            return i != -1 && i == s.LastIndexOf(sub);
        }
    }
}
