using System.Collections.Generic;

namespace PlayerManager4
{
    public interface IView
    {
        int MainMenu();

        void InvalidOption();

        void ShowPlayers(IEnumerable<Player> players);

        Player AskForPlayer();

        int AskForMinimumScore();

        PlayerOrder AskPlayerOrder();
    }
}