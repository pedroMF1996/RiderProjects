namespace System
{
    public static class StringExtentions
    {
        public static string Cut(this string thisObj, int num)
        {
            if (thisObj.Length <= num)
            {
                return thisObj;
            }
            else
            {
                return $"{thisObj.Substring(0,num)}...";
            }
        }
    
}
}