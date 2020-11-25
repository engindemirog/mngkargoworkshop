namespace Workshop6
{
    class OfficerCreditManager :BaseCreditManager
    {
        public override double Calculate(Credit credit)
        {
            return credit.Amount * credit.Interest;
        }
    }
}
