using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Pig : Omnivore
    {
        public override void SayHello()
        {
            base.SayHello();
            Text.text = "oink oink";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            Text.text = "munch munch oink";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            Text.text = "nomnomnom oink thx";
        }

        public override void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }
    }
}
