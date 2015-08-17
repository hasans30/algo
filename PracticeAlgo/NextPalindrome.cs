using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAlgo
{
    class NextPalindrome
    {
        public static void ComputeNextPalindrome(int [] input)
        {
            int length = input.Length;
            int leftIndex = -1;
            int rightIndex = -1;

            if (length%2 != 0)
            {
                //odd no. of digits
                leftIndex = length / 2;
                rightIndex = leftIndex + 1;
            }
            else
            {
                leftIndex = rightIndex = length / 2;
            }


            //for even no. of digit
            //reverse 0 to leftindext and compare with rightindex to end
            //if reversed part is > second half -- construct abccba
            //else abc+1=xyz assume and answer is xyzzyx

            //for odd no. of digit
            //reverse 0 to leftindex and compare rightindex

        }
    }
}
