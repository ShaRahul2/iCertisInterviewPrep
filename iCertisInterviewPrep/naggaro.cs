using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCertisInterviewPrep
{
    class naggaro
    {
        #region Naggaro Interview Question
        // Question 1 Rearrange The string remove _ and char will be upper string case and if upper case string then make it lower()

        protected static string ModifyVariableName(string input)
        {
            input = input.Trim();
            if (string.IsNullOrEmpty(input)) return input;
            string result1 = String.Empty;
            if (!input.Contains("_"))
            {
                for (int i = 0; i < input.Length; i++)
                {

                    if (Char.IsUpper(input[i]))
                    {
                        result1 += "_";
                        result1 += input[i].ToString().ToLower();
                    }
                    else result1 += input[i];
                }
                return result1;
            }

            String result = "";
            for (int i = 0; i < input.Length; i++)
            {
                //if (char.IsUpper(input[i]))
                //{
                //    result += "_" + char.ToLower(input[i]);
                //}
                //else 
                if (input[i] == '_')
                {
                    i++;
                    result += char.ToUpper(input[i]);
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }

        // Question 2 find duplicate from int array
        public static int[] DisplayArray()
        {
            int[] input2 = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int input1 = input2.Length;
            ArrayList dup = new ArrayList();
            //List<int> dup = new List<int>();
            for (int i = 0; i < input1; i++)
            {
                for (int j = i + 1; j < input1; j++)
                {
                    if (input2[i].Equals(input2[j]))
                    {
                        if (!dup.Contains(input2[i]))
                        {
                            dup.Add(input2[i]);
                        }
                    }
                }
            }
            dup.Sort();
            return dup.Cast<int>().ToArray();

        }
        #endregion
    }
}
