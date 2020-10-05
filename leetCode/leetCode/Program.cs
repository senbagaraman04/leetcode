using System;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arg0 = { 1, 2, 3 };

            int[] ans =   question1(arg0,3);
            int ans7 = question7(132);
            Console.ReadLine();
        }

        private static int question7(int num)
        {
            //Given a 32-bit signed integer, reverse digits of an integer.
            int reversedNumber = 0;
            int isNegative = 0;
           

int result=0;
if(num < 0) {
    result = result * -1;
    isNegative = 1;

}
 
    while (num>0) 
    {
       result = result*10 + num%10;
       num /= 10;
    }

    if(isNegative == 1)
    {
       result = result * -1;
    }
    return result;
        }

        private static int[] question1(int[] nums, int target)
        {
            //  Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            //You may assume that each input would have exactly one solution, and you may not use the same element twice.
            //You can return the answer in any order.

            //  Example 1:

            //Input: nums = [2, 7, 11, 15], target = 9
            //Output: [0, 1]
            //Output: Because nums[0] +nums[1] == 9, we return [0, 1].
            //Example 2:

            //Input: nums = [3, 2, 4], target = 6
            //Output: [1, 2]
            //Example 3:

            //Input: nums = [3, 3], target = 6
            //Output: [0, 1]
 
                int[] ans = new int[2];


                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            ans[0] = i;
                            ans[1] = j;
                        }
                    }
                }
                return ans;     
        }
    }
}
