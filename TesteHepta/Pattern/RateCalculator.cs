namespace TesteHepta.Pattern
{
    public abstract class RateCalculator
    {
        public int CalculateRate(string[] diagnosticReport)
        {
            int bitLength = diagnosticReport[0].Length;
            int[] rateBits = new int[bitLength];

            for (int i = 0; i < bitLength; i++)
            {
                int count0 = 0;
                int count1 = 0;

                foreach (var binaryNumber in diagnosticReport)
                {
                    if (binaryNumber[i] == '0')
                        count0++;
                    else
                        count1++;
                }

                rateBits[i] = DetermineBitValue(count0, count1);
            }

            return Convert.ToInt32(string.Join("", rateBits), 2);
        }

        protected abstract int DetermineBitValue(int count0, int count1);
    }
}
