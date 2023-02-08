namespace SampleSmsIr.Dll.Tools
{
    public static class Converters
    {
        public static int? ToNullableInt(this string value)
        {
            if (int.TryParse(value, out int result))
                return result;
            return null;
        }
    }
}