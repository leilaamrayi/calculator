using System;
namespace Calculator
{
   public class Calculator
    {
        public static void Main(string[] args)
        {
            string Option = "";
            
            while (Option != "0")
            {
                Console.WriteLine("please select one of options!   " + "1: ADD  " + "2: SUBSTRACT   " + "3: MULTIPLY   " + "4: DIVIDE  " + "0: exit");
                Option = Console.ReadLine();
                
                if (Option == "0")
                {
                    continue; // go to next loop in the current while block
                }
                
                switch (Option)
                {
                    case "1":
                        HandleAdd();
                        break;

                    case "2":
                        HandleSubstract();
                        break;

                    case "3":
                        HandleMultiply();
                        break;

                    case "4":
                        HandleDivide();
                        break;                        

                    default:
                        Console.WriteLine("you selected wrong option ");
                        break;

                }
            }
            
        }

        public static void HandleAdd()
        {
            double[] nums = GetNums();
            Console.WriteLine("the answer is :  " + Add(nums));
        }

        public static double Add(double[] nums) 
        {
            double result = 0;
            foreach (double num in nums)
            {
                result += num;
            }
            return result;
        }

        public static void HandleSubstract()
        {
            double[] nums = GetNums();
            Console.WriteLine("the answer is :  " + Substract(nums));
        }

        public static double Substract(double[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            double result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result -= nums[i];
            }
            return result;
        }

        public static void HandleMultiply()
        {
            double[] nums = GetNums();
            Console.WriteLine("the answer is :  " + Multiply(nums));
        }

        public static double Multiply(double[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            double result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result *= nums[i];
            }
            return result;
        }

        public static void HandleDivide()
        {
            double[] nums;

            while (true)
            {
                nums = GetNums();
                if (!InputIsValidForDivide(nums))
                {
                    Console.WriteLine("Cannot divide by zero! Please try again.");
                    continue;
                }
                else 
                {
                    break;
                }
            }

            Console.WriteLine("the answer is :  " + Divide(nums));
        }

        public static double Divide(double[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            double result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result /= nums[i];
            }
            return result;
        }

        public static bool InputIsValidForDivide(double[] nums)
        {
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static double[] GetNums()
        {
            Console.WriteLine("please enter some numbers separated by a space:");
            String input = Console.ReadLine();
            return ParseInputToNumbers(input);
        }

        public static double[] ParseInputToNumbers(string? input)
        {
            if (string.IsNullOrEmpty(input)) 
            {
                return new double[0];
            }

            List<double> nums = new List<double>();
            String[] sections = input.Split(" ");
            foreach (String s in sections)
            {
                try
                {
                    nums.Add(Convert.ToDouble(s.Trim()));
                }
                catch (Exception e) 
                {}
            }
            return nums.ToArray();
        }
    }
}
  
    
   
 


  




