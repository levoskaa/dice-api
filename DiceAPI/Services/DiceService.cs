using DiceAPI.ViewModels;
using System;

namespace DiceAPI.Services
{
    public class DiceService : IDiceService
    {
        private readonly Random rnd;

        public DiceService()
        {
            rnd = new Random();
        }

        public DiceThrowVM Roll(int diceSize, int diceCount)
        {
            int[] result = new int[diceCount];
            for (int i = 0; i < diceCount; ++i)
            {
                result[i] = rnd.Next(1, diceSize + 1);
            }
            return new DiceThrowVM
            {
                Result = result
            };
        }
    }
}
