namespace Testing
{
    public static class Main
    {
        public static Run()
        {
            var pirateShip = new
            {
                cannons: 3,
                sails: 4
            }

            pirateShip
              .Transform(Move.Parameterize(1, 23))
              .Transform(Fire.Parameterize(1, 3))
              .Transform(Move.Parameterize(1, 23))
              .Into(out pirateShip);

            var commandSequence1 =
              Move.Parameterize(1, 23))
              .Compose(Fire.Parameterize(1, 3))
              .Compose(Move.Parameterize(1, 23));

            var commandSequence2 = Func<PirateShip, int, PirateShip>((ship, distance) =>
              pirateShip
                .Transform(Move.Parameterize(1, 23))
                .Transform(Fire.Parameterize(1, 3))
                .Transform(Move.Parameterize(1, 23));
        }
    }
}
