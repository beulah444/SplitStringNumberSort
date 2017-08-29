using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
class Program
    {
    static void Main()
    {
  
            Console.WriteLine("enter your string");
            string strUserInput1 = Console.ReadLine();
            string letters = new string(strUserInput1.TakeWhile(c => char.IsLetter(c)).ToArray());
            string number = new string(strUserInput1.Skip(letters.Length).TakeWhile(c => char.IsDigit(c)).ToArray());
            Console.WriteLine(" using linq- Letter= {0}, number= {1}", letters, number);
            Regex regex = new Regex(@"([a-zA-Z]+)(\d+)");
            Match result1 = regex.Match(strUserInput1);
            string alphapart = result1.Groups[1].Value;
            string numberpart = result1.Groups[2].Value;
            Console.WriteLine("using regular expressions- Letter= {0}, number= {1}", alphapart, numberpart);
        //Regex numberpattern = new Regex(@"(\d{525}$+)(\d{528}$+)(\d{+)");  

    Regex re = new Regex(@"([a-zA-Z]+)(\d+)([a-zA-Z]+)");
        string strUserDecision = string.Empty;
        do
        {
            //Regex anyexperession = new Regex(@"(?<number>\d+)(?<letter>[a-zA-Z]+)|(?<letter>[a-zA-Z]+)(?<number>\d+)");
            Console.WriteLine("Please enter the string");
            string strUserInput = Console.ReadLine();
            Match result = re.Match(strUserInput);
            string alphaPart1 = result.Groups[1].Value;
            string numberPart = result.Groups[2].Value;
            string alphaPart2 = result.Groups[3].Value;
            string SortedalphaPart1 = string.Concat(alphaPart1.OrderBy(c => c));
            string SortednumberPart = string.Concat(numberPart.OrderBy(c => c));
            string SortedalphaPart2 = string.Concat(alphaPart2.OrderBy(c => c));
            string SortedString = string.Join("", SortedalphaPart1, SortednumberPart, SortedalphaPart2);
            Console.WriteLine("sorted string = {0}", SortedString);

            //Match result1 = anyexperession.Match(strUserInput);
            //string letter = result1.Groups["letter"].Value;
            //int number = int.Parse(result1.Groups["number"].Value);
            //Console.WriteLine("Letter={0},Number={1}", letter, number);
            do
            {
                Console.WriteLine("Do you want to continue? YES or NO");
                strUserDecision = Console.ReadLine().ToUpper();
            } while (strUserDecision != "YES" && strUserDecision != "NO");
        } while (strUserDecision == "YES");
        Console.Write("Press nay key to exit");
        Console.ReadKey();
    }
    
    }
