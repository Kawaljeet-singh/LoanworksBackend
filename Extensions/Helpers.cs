namespace LoanworksBackend.Extensions;

public static class Helpers
{
    /// <summary>
    /// This extension class converts an int to an equivalent alphabet (e.g. 1=A, 2=B,..27=AA)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetAlphabetFromInt(this int value)
    {
        if (value <= 26)
        {
            return ((Char)((true ? 65 : 97) + (value - 1))).ToString();
        }
        else
        {
            int numberOfChars = value / 26;

            string response = numberOfChars.GetAlphabetFromInt();
            if (numberOfChars == 1)
                value = value - (26 * numberOfChars);
            else
                value = value - (26 * numberOfChars) + 1;

            return response + (((Char)((true ? 65 : 97) + (value - 1))).ToString());
        }
    }
}
