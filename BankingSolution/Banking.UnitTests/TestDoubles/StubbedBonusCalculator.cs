

namespace Banking.UnitTests.TestDoubles
{
    public class StubbedBonusCalculator : ICalculateBonuses
    {
        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
        {
            return currentBalance == 5000M && amountOfDeposit == 32.42M ? 42 : 0;
        }
    }
}
