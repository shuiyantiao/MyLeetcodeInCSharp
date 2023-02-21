namespace AnswerLib._1_100
{
    public class _8
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            if (string.IsNullOrWhiteSpace(s) == true) return 0;
            bool isMinus = false;
            if (s[0] == '-' || s[0] == '+')
            {
                isMinus = s[0] == '-';
                s = s.Substring(1);
            }
            long total = 0;
            foreach (var c in s)
            {
                var num = CharToNum(c);
                if (num >= 0)
                {
                    total *= 10;
                    total += num;
                    if (total > int.MaxValue)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            if (total > int.MaxValue)
            {
                return isMinus ? int.MinValue : int.MaxValue;
            }
            return isMinus ? 0 - (int)total : (int)total;
        }

        public int CharToNum(char c)
        {
            return c switch
            {
                '0' => 0,
                '1' => 1,
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                '+' => -1,
                '-' => -1,
                _ => -2,
            };
        }
    }
}
