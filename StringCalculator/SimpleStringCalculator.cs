using System;

namespace SimpleStringCalculator
{
    public class SimpleStringCalculator
    {
        public static int Add(string numbers)
        {
            if (StringIsNullOrEmpty(numbers))
            {
                return EmptyString();
            }
            return (0);
        }


        public static bool StringIsNullOrEmpty(string numbers)
            {
                return string.IsNullOrEmpty(numbers);
            }

            public static int EmptyString()
            {
                return 0;
            }
        }
    }