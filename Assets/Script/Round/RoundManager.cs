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
            
            new Round(new[] // 4
            {
                new BloonGroup(0, BloonType.Red, 25, 12f),
                new BloonGroup(7.9f, BloonType.Blue, 18, 2.5f),
                new BloonGroup(14.5f, BloonType.Red, 10, 2.8f)
            }),
            
            new Round(new[] // 5
            {
                new BloonGroup(0, BloonType.Blue, 12, 5.1f),
                new BloonGroup(5.7f, BloonType.Red, 5, 2.5f),
                new BloonGroup(8.6f, BloonType.Blue, 15, 8f)
            }),
            
            new Round(new[] // 6
            {
                new BloonGroup(0, BloonType.Green, 4, 1.7f),
                new BloonGroup(5.3f, BloonType.Red, 15, 5f),
                new BloonGroup(10.2f, BloonType.Blue, 15, 8f)
            }),
        };
    }
}