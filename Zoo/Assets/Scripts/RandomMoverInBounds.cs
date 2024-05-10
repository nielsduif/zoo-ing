using UnityEngine;

namespace Zoo
{
    public class RandomMoverInBounds : MonoBehaviour
    {
        [SerializeField]
        private int left, right, top, bottum;
        [SerializeField]
        private float speed;
        private Vector3 goal;
        private float boundaryThreshold = 5;

        private void Start()
        {
            PickGoal();
        }

        private void Update()
        {
            Vector3 direction = goal - transform.localPosition;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
            if (direction.magnitude < boundaryThreshold)
            {
                PickGoal();
            }
        }

        private void PickGoal()
        {
            goal = new Vector2(Random.Range(left, right), Random.Range(bottum, top));
        }
    }
}