namespace Zoo
{
    class Herbivore : Animal
    {
        public virtual void EatLeaves()
        {
            Balloon.SetActive(true);
        }
    }
}