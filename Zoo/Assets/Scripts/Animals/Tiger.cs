using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Tiger : Carnivore
    {
        public override void SayHello()
        {
            base.SayHello();
            Text.text = "rraaarww";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            Text.text = "nomnomnom thx wubalubadubdub";
        }

        public override void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }
    }
}