namespace AnswerLib._1_100
{
    public class _1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> targetNums = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (targetNums.TryGetValue(nums[i], out int pos))
                {
                    return new int[] { pos, i };
                }
                targetNums.TryAdd(target - nums[i], i);
            }
            return Array.Empty<int>();
        }
    }
}
