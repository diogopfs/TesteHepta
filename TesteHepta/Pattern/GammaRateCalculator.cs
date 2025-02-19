namespace TesteHepta.Pattern
{
    public class GammaRateCalculator : RateCalculator
    {
        protected override int DetermineBitValue(int count0, int count1)
        {
            return (count1 >= count0) ? 1 : 0;
        }
    }
}
