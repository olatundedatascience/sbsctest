using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using System.Text.RegularExpressions;

namespace sbscassessment
{
    public class Assessment
    {

        public static string numberOfLetterOccurence(string input)
        {
            Dictionary<string, int> letterOccurences = new Dictionary<string, int>();
            List<string> countedVarirables = new List<string>();
            foreach (var currentInput in input)
            {
                var current = currentInput.ToString().ToLower();

                if(countedVarirables.Contains(current))
                {
                    // string getCurrent = letterOccurences.Keys.Where(x=>x == current).FirstOrDefault();
                    letterOccurences.TryGetValue(current, out int currentInputOccurence);

                    if(currentInputOccurence != 0)
                    {
                        letterOccurences[current] = currentInputOccurence + 1;
                    }
                    
                }
                else
                {
                    letterOccurences.Add(current, 1);
                }

                countedVarirables.Add(current);
                
            }

            StringBuilder answer = new StringBuilder();

            foreach(var k in letterOccurences)
            {
                answer.Append($"{k.Key}{k.Value}");
            }
            return answer.ToString();

        }

        public static bool IntervalBeetweenNumbers (string input)
        {
            List<string> inputSplitted = input.Split("-").ToList<string>();
            int intervalBetweenFirstAndSecond = Math.Abs(Convert.ToInt32(inputSplitted[0]) - Convert.ToInt32(inputSplitted[1]));
            int indexToStartFrom = 2;
            bool result = false;

            while(indexToStartFrom < inputSplitted.Count)
            {
                
                try
                {
                    var current = Convert.ToInt32(inputSplitted[indexToStartFrom]);
                    var last = Convert.ToInt32(inputSplitted[inputSplitted.Count - 1]);

                    if (current != last)
                    {                        
                        var next = Convert.ToInt32(inputSplitted[indexToStartFrom + 1]);

                        var difference = Math.Abs(current - next);

                        if (difference != intervalBetweenFirstAndSecond)
                        {
                            result = false;
                            break;
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
                catch
                {
                    
                   
                        result = false;
                        break;
                  
                }
                
                indexToStartFrom += 1;
            }
            

            return result;
        }
    }
}
