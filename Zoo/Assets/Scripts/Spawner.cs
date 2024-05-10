using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] animals;
        [SerializeField]
        private string[] names = { "beer", "henk", "knol", "elsa", "dora", "wally", "marty" };
        [SerializeField]
        AnimalManager animalManager;

        private void OnEnable()
        {
            for (int i = 0; i < animals.Length; i++)
            {
                Animal animal = Instantiate(animals[i], transform).GetComponent<Animal>();
                animal.AnimalName = names[i];
                animalManager.Animals.Add(animal);
            }
        }
    }
}