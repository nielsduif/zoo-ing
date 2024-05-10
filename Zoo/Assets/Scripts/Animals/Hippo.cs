namespace Zoo
{
    class Hippo : Herbivore
    {
        public override void SayHello()
        {
            base.SayHello();
            Text.text = "splash";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            Text.text = "munch munch lovely";
        }
    }
}
