using System.Collections;
using UnityEngine;

namespace Zoo
{
    class Bear : Omnivore
    {
        public override void SayHello()
        {
            base.SayHello();
            Text.text = "roar";
        }

        public override void EatLeaves()
        {
            base.EatLeaves();
            Text.text = "get spinach";
        }

        public override void EatMeat()
        {
            base.EatMeat();
            Text.text = "liver king style";
        }

        public override void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }
    }
}
