namespace AnimInterf
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings => 4;

        public override string Sound()
        {
            return base.Sound() + "Bzzzzz";
        }
    }
}