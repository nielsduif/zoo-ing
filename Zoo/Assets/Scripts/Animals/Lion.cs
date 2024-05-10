namespace Zoo
{
    class Lion : Carnivore
    {
        public override void SayHello()
        {
            base.SayHello();
            Text.text = "roooaoaaaaar";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            Text.text = "nomnomnom thx mate";
        }
    }
}