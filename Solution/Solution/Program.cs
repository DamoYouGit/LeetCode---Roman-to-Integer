

var run = new Solution();

run.RomanToInt("MCMXCIV");
public class Solution
{
    public int RomanToInt(string s)
    {

        int total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'M')
            {
                if (i > 0)
                {
                    if (s[i - 1] == 'C')
                    {
                        total = total + 900 - 100;
                    }
                    else
                    {
                        total = total + 1000;
                    }
                }
                else
                {
                    total = total + 1000;
                }

            }
            else if (s[i] == 'D')
            {

                if (i > 0)
                {
                    if (s[i - 1] == 'C')
                    {
                        total = total + 400 - 100;
                    }
                    else
                    {
                        total = total + 500;
                    }
                }
                else
                {
                    total = total + 500;
                }

            }
            else if (s[i] == 'C')
            {
                if (i > 0)
                {
                    if (s[i - 1] == 'X')
                    {
                        total = total + 90 - 10;
                    }
                    else
                    {
                        total = total + 100;
                    }
                }
                else
                {
                    total = total + 100;
                }

            }
            else if (s[i] == 'L')
            {
                if (i > 0)
                {
                    if (s[i - 1] == 'X')
                    {
                        total = total + 40 - 10;
                    }
                    else
                    {
                        total = total + 50;
                    }
                }
                else
                {
                    total = total + 50;
                }

            }
            else if (s[i] == 'X')
            {

                if (i > 0)
                {
                    if (s[i - 1] == 'I')
                    {
                        total = total + 9 - 1;
                    }
                    else
                    {
                        total = total + 10;
                    }
                }
                else
                {
                    total = total + 10;
                }

            }
            else if (s[i] == 'V')
            {
                if (i > 0)
                {
                    if (s[i - 1] == 'I')
                    {
                        total = total + 4 - 1;
                    }
                    else
                    {
                        total = total + 5;
                    }
                }
                else
                {
                    total = total + 5;
                }


            }
            else if (s[i] == 'I')
            {
                if (i > 0)
                {
                    if (s[i - 1] == 'V')
                    {
                        total = total + 1;
                    }
                    else
                    {
                        total = total + 1;
                    }
                }
                else
                {
                    total = total + 1;
                }

            }
        }

        return total;

    }
}
