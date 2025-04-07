
namespace ID.WPF.Chess.v1.Core
{
    public enum Player
    {
        None,
        White,
        Black
    }

    public static class PlayerExtensions
    {
        public static Player Opponent(this Player player)
        {
            return player switch
            {
                Player.White => Player.Black,
                Player.Black => Player.White,
                _ => Player.None,
            };
        }
    }
}
