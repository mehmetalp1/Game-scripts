using System.Collections;
using UnityEngine;

namespace NavKeypad
{
    public class SlidingDoor : MonoBehaviour
    {
        [SerializeField] private float slidingSpeed = 1.0f;
        [SerializeField] private float slideDistance = 3.0f; // Kapının kaç birim aşağı ineceği
        private Vector3 closedPosition;
        private Vector3 openPosition;
        private bool isOpen = false;

        private void Start()
        {
            // Kapı başlangıçta kapalı pozisyonda olsun
            closedPosition = transform.position;
            openPosition = closedPosition - new Vector3(0, slideDistance, 0);
        }

        public void ToggleDoor()
        {
            isOpen = !isOpen;
            StartCoroutine(MoveDoor(isOpen ? openPosition : closedPosition));
        }

        public void OpenDoor()
        {
            isOpen = true;
            StartCoroutine(MoveDoor(openPosition));
        }

        public void CloseDoor()
        {
            isOpen = false;
            StartCoroutine(MoveDoor(closedPosition));
        }

        private IEnumerator MoveDoor(Vector3 targetPosition)
        {
            while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
            {
                transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * slidingSpeed);
                yield return null;
            }

            // Hareket tamamlandıktan sonra, pozisyonu hedefe sabitle
            transform.position = targetPosition;
        }
    }
}
