namespace Zoo
{
    class Horse : Herbivore
    {
        public override void SayHello()
        {
            base.SayHello();
            Text.text = "hinnik";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            Text.text = "protein check";
        }
    }
}