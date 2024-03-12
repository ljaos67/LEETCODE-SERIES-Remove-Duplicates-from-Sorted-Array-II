public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int a = -1;
        int b = nums.Length;
        int max = nums.Max() + 1;
        bool check = false;

        for(int i = 0; i < nums.Length; i++)
        {
            if(i == 0)
            {
                a = nums[0];
            }
            else if(nums[i] == a)
            {
                if(check)
                {
                    nums[i] = max;
                    b--;
                }
                else
                {
                    check = true;
                }
            }
            else
            {
                check = false;
                a = nums[i];
            }
        }
        Array.Sort(nums);
        return b;   
    }
}
