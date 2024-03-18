using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insanhareketi : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Yatay hareket girişlerini al
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Kameranın yatay yönünü al
        Vector3 cameraForward = Camera.main.transform.forward;
        cameraForward.y = 0f; // Y eksenini sıfıra ayarla

        // Kameranın sağ yönünü al
        Vector3 cameraRight = Camera.main.transform.right;

        // Yatay hareket girişlerini kameranın yönüne göre düzenle
        Vector3 movement = (cameraForward.normalized * verticalInput + cameraRight.normalized * horizontalInput) * moveSpeed * Time.deltaTime;

        // Y eksenindeki hareketi sıfıra ayarla
        movement.y = 0f;

        // Karakterin pozisyonunu güncelle
        transform.Translate(movement);
    }
}
