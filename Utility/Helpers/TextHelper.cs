namespace Utility.helpers
{
    public class TextHelper
    {

        // Method to minimize the length of a string using all strategies
        public static string MinimizeLength(string? input, int maxLength)
        {
            if (string.IsNullOrEmpty(input) || maxLength <= 0)
                return string.Empty;

            return input.Length <= maxLength ? input : input.Substring(0, maxLength) + "...";
        }
    }
}
