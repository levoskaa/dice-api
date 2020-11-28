using DiceAPI.ViewModels;

namespace DiceAPI.Services
{
    public interface IDiceService
    {
        DiceThrowVM Roll(int diceSize, int diceCount);
    }
}
