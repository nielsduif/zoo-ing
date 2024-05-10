using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Zoo
{
    class AnimalManager : MonoBehaviour
    {
        private List<Animal> animals = new List<Animal>();
        private List<Herbivore> herbivores;
        private List<Carnivore> carnivores;
        private List<Omnivore> omnivores;
        private string inputName = "";

        public List<Animal> Animals
        {
            get { return animals; }
        }

        public string InputName
        {
            set { inputName = value; }
            get { return inputName; }
        }

        private void Start()
        {
            herbivores = animals.OfType<Herbivore>().ToList();
            carnivores = animals.OfType<Carnivore>().ToList();
            omnivores = animals.OfType<Omnivore>().ToList();
        }

        public void GiveLeaves()
        {
            foreach (Herbivore animal in herbivores)
            {
                animal.EatLeaves();
            }
            foreach (Omnivore animal in omnivores)
            {
                animal.EatLeaves();
            }
        }

        public void GiveMeat()
        {
            foreach (Carnivore animal in carnivores)
            {
                animal.EatMeat();
            }
            foreach (Omnivore animal in omnivores)
            {
                animal.EatMeat();
            }
        }

        public void PerformTrick()
        {
            foreach (Animal animal in animals)
            {
                animal.PerformTrick();
            }
        }

        public void SayHello()
        {
            foreach (Animal animal in animals)
            {                   
                if (InputName == "" | InputName == animal.AnimalName)
                {
                    animal.SayHello();
                }
            }
        }
    }
}

