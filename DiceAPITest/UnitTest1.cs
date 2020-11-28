using DiceAPI.Services;
using DiceAPI.ViewModels;
using System;
using Xunit;

namespace DiceAPITest
{
    public class UnitTest1
    {
        DiceService diceService;

        [Fact]
        public void DiceWithSixOnceSuccessfully()
        {
            diceService = new DiceService();
            DiceThrowVM result;

            result = diceService.Roll(6,1);

            Assert.True(result.Result[0] <= 6);
            Assert.True(result.Result[0] >= 0);
        }
    }
}
