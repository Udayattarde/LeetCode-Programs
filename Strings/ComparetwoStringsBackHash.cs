namespace Strings
{
    public class ComparetwoStringsBackHash
    {

        private static string ProcessWithLinqAlternative(string str)
        {
            return new string(
                str.Aggregate("", (current, c) =>
                {
                    if (c == '#')
                        return current.Length > 0 ? current.Substring(0, current.Length - 1) : current;
                    else
                        return current + c;
                }).ToCharArray()
            );
        }

        public static bool CompareStringsWithLinq(string str1, string str2)
        {
            return ProcessWithLinqAlternative(str1).SequenceEqual(ProcessWithLinqAlternative(str2));
        }
        static void Main(string[] args)
        {
            string str1 = "bcd##e";
            string str2 = "bd#e";
            bool result = CompareStringsWithLinq(str1, str2);

            // Print the result
            Console.WriteLine("Comparison Result: " + result);
        }
    }
}
