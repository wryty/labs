namespace libs
{
    public class Class1
    {
        static public string LTrim(string str)
        {
            int spaceIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    spaceIndex = i;
                    break;
                }
            }
            return str.Substring(spaceIndex);
        }
        static public string RTrim(string str)
        {
            int spaceIndex = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    spaceIndex = i;
                    break;
                }
            }

            return str.Substring(0, spaceIndex + 1);
        }
        static public string Trim(string str)
        {
            return RTrim(LTrim(str));
        }
    }
}