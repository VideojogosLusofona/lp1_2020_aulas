using System.Collections.Generic;

namespace PlayerManager2
{
    public interface IView
    {
        int MainMenu();

        void InvalidOption();

        void ShowPlayers(IEnumerable<Player> players);

        Player AskForPlayer();

        int AskForMinimumScore();
    }
}