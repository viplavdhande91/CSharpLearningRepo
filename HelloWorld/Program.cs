namespace Cal
{
    class Maths
    {
        public static void Main(string[] args)
        {
            int outVar;
            int refVar = 55;
            GetNextName(out outVar, ref refVar);
        }

        public static int GetNextName(out int outVar, ref int refVar)
        {
            outVar = 1;
            return outVar + refVar;
        }
    };
}