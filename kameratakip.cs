using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public Transform hedef; // Takip edilecek nesnenin referansı
    public float kameraYukseklik = 3.0f; // Kameranın yüksekliği

    void LateUpdate()
    {
        if (hedef != null)
        {
            // Hedefin pozisyonunu al
            Vector3 hedefPozisyon = hedef.position;

            // Kamerayı hedefin pozisyonuna taşı (mesafe ve yükseklik eklenmemiş)
            transform.position = new Vector3(hedefPozisyon.x, hedefPozisyon.y + kameraYukseklik, hedefPozisyon.z);
        }
    }
}
