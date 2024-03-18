using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecis : MonoBehaviour
{
    // Butona tıklanınca geçilecek sahne adı
    public string hedefSahneAdi;

    // Butona tıklama işlemi
    public void ButonaTiklandi()
    {
        // Sahne geçişini gerçekleştir
        SceneManager.LoadScene(hedefSahneAdi);
    }
}
