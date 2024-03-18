using UnityEngine;

public class mauskontrol : MonoBehaviour
{
    public float hassasiyet = 2.0f; // Fare hassasiyeti

    float rotationX = 0;

    void Update()
    {
        // Fare hareketi alma
        float mouseX = Input.GetAxis("Mouse X") * hassasiyet;
        float mouseY = Input.GetAxis("Mouse Y") * hassasiyet;

        // Kameranın yatay dönüşü (sağa sola bakma)
        transform.Rotate(Vector3.up * mouseX);

        // Kameranın dikey dönüşü (yukarı aşağı bakma)
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -85, 85); // Clamp to ensure the rotation stays between -85 and 85 degrees

        // Kameranın rotasyonunu güncelleme
        transform.localRotation = Quaternion.Euler(rotationX, transform.localRotation.eulerAngles.y, 0);
    }
}
