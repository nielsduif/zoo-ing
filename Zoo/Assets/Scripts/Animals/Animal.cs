using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Animal : MonoBehaviour
    {
        private string animalName;
        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        public GameObject Balloon
        {
            get { return balloon; }
        }

        public Text Text
        {
            get { return text; }
        }

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }

        public virtual void SayHello()
        {
            Balloon.SetActive(true);
        }

        public virtual void PerformTrick()
        {

        }

        public virtual IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}