namespace Zoo
{
    class Carnivore : Animal
    {
        public virtual void EatMeat()
        {
            Balloon.SetActive(true);
        }
    }
}