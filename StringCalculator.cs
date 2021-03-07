using System;

namespace dotnetcore
{
    class StringCalculator
    {
        public int Add(string numbers)
        {
            int result = 0;
           
            if(numbers.Length == 0)
            {
                 result = 0;
            }
           
            else if(!numbers.Contains(',') && !numbers.Contains('\n'))
            {
                result = Convert.ToInt32(numbers);
                
            }
            
            else
            {

                string[] number = numbers.Split('\n',',');
                foreach (var num in number)
                {
                    result += Convert.ToInt32(num);
                }
             }

            
            return result;
        }
    }
}
