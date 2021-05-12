namespace AnimInterf
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples => 2;

        public int NumberOfWings => 2;

        public override string Sound()
        {
            return base.Sound() + "Sportiiiiing";
        }
    }
}