namespace Bloonz.Round
{
    public class RoundManager
    {
        public static readonly Round[] Rounds = new[]
        {
            new Round(new[] // 1
            {
                new BloonGroup(0, BloonType.Red, 20, 17.5f)
            }),
            
            new Round(new[] // 2
            {
                new BloonGroup(0, BloonType.Red, 35, 10f)
            }),
            
            new Round(new[] // 3
            {
                new BloonGroup(0, BloonType.Red, 10, 5f),
                new BloonGroup(5.5f, BloonType.Blue, 5, 2.5f),
                new BloonGroup(8.2f, BloonType.Red, 15, 6f)
            }),
        };
    }
}