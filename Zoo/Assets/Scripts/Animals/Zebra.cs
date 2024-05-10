namespace Zoo
{
    class Zebra : Herbivore
    {
        public override void SayHello()
        {
            base.SayHello();
            Text.text = "zebra zebra";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            Text.text = "munch munch zank yee bra";
        }
    }
}