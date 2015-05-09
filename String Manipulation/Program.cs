using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
//Prompt a user to input a string of any kind into the console. Then, ignoring special characters,
//increment each letter one farther down the alphabet (e.g. a->b, o->p, z->a, etc.). 
//Return the string to the console.
{
    class Program
    {

       
        static void Main(string[] args)
        {
            
            string password;
            Console.WriteLine("Please enter a word");
            password = Console.ReadLine();
            
            foreach(char letter in password)
            {
                Console.Write(GoThroughAlphabet(letter));
               
            }

           
            Console.ReadLine();
        }
        static char GoThroughAlphabet(char wordletter)
        {
            char[] alphabet = new char[54] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K','L', 'M', 'N', 'O', 'P', 'Q',
            'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y','Z', 'A', 'a', 'b', 'c', 'd','e', 'f' , 'g' , 'h' ,'i', 'j' , 'k', 'l', 'm', 'n' ,
            'o','p' , 'q' ,'r' , 's', 't' , 'u', 'v' , 'w', 'x', 'y', 'z', 'a'};
           // char lettertoreturn = 'o';
            char lettertoreturn = '0';
            for (int i = 0; i < alphabet.Length; i++)
            {

                if (wordletter == alphabet[i])
                {
                    lettertoreturn = alphabet[i + 1];
                    break;
                }
                               
            }
            
            return lettertoreturn;
        }

    }
}




//So, make a method that checks a leter against the Alphabet array and returns the letter exxacctly after it.  Pass in each letter from the Password Array with a 
//for each loop)
 //for (int i = 0; i < alphabet.Length; i++)
          //  {
            //    foreach (char passwordLetter in password)
            //    {
           //         if (alphabet[i] == password[i])
             //       {
                 //       char s = alphabet[i + 1];

                //        Console.WriteLine(s);
               //     }
            //     }
                  
          //   }

//   foreach (char passwordLetter in password)
// {

//     for (int i = 0; i < alphabet.Length; i++)
//    {
//       if (alphabet[i] == password[i])
//    {
//         char s = alphabet[i + 1];

//       Console.WriteLine(s);
// }
// }


// foreach (char l in letters)
//  {
//   if (i == l)
//   {
//Console.WriteLine(i);

//    }