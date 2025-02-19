namespace TesteHepta.Pattern
{
    public class EpsilonRateCalculator : RateCalculator
    {
        protected override int DetermineBitValue(int count0, int count1)
        {
            return (count1 >= count0) ? 0 : 1; // Bit menos comum
        }
    }
}
