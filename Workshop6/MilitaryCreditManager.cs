namespace Workshop6
{
    class MilitaryCreditManager : BaseCreditManager
    {
        public override double Calculate(Credit credit)
        {
            return credit.Amount * credit.Interest;
        }
    }
}
