namespace Zoo
{
    class Omnivore : Animal
    {
        public virtual void EatMeat()
        {
            Balloon.SetActive(true);
        }

        public virtual void EatLeaves()
        {
            Balloon.SetActive(true);
        }
    }
}