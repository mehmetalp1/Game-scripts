using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NavKeypad
{ 
    public class KeypadInteractionFPV : MonoBehaviour
    {
        public Texture2D crosshairTexture; // Crosshair için kullanılacak texture
        public int crosshairSize = 32; // Crosshair'ın boyutu

        private Camera cam;

        private void Awake() 
        {
            cam = Camera.main;
            Cursor.visible = false; // Fare imlecini gizle
        }

        private void OnGUI()
        {
            // Crosshair'ı eklemek için GUI üzerine texture çizdirme
            GUI.DrawTexture(new Rect(Screen.width / 2 - crosshairSize / 2, Screen.height / 2 - crosshairSize / 2, crosshairSize, crosshairSize), crosshairTexture);
        }

        private void Update()
        {
            var ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0)); // Ekranın ortasına gönderilen ray

            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out var hit))
                {
                    if (hit.collider.TryGetComponent(out KeypadButton keypadButton))
                    {
                        keypadButton.PressButton();
                    }
                }
            }
        }
    }
}
