using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Name_Scores
{
    //Use the names.txt file, a 46K text file containing over five-thousand first names found in the resources directory.
//Part 1:Begin by sorting the list into alphabetical order. Save this new file as p4aNames.txt in the answers directory.
    //Part 2: Using p4aNames.txt, take the alphabetical value for each name, and multiply this value by its alphabetical 
    //position in the list to obtain a name score. For example, when the list is sorted into alphabetical order, COLIN, 
    //which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain
    //a score of 938 × 53 = 49714. Save the list of all name scores as p4bNames.txt.
    //Part 3:What is the total of all the name scores in the file?

    class Program
    {
        static void Main(string[] args)
        {

            
            using(StreamReader names = new StreamReader("names.txt"))
            {
              
            }
            using (StreamWriter writer = new StreamWriter("P4names.txt"))
            {
             
                
            }
        }
    }
}
