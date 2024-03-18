using UnityEngine;

public class rastgeleobjespawner : MonoBehaviour
{
    public GameObject objecttToSpawn; // Spawn edilecek obje
    public float waitTime = 3f; // Bekleme süresi (saniye)
    float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            // Burada spawn edebilirsin.
            SpawnObjectt();

            timer = 0f; // Timer'ı sıfırla
        }
    }

    private void SpawnObjectt()
    {
        // X ekseni için rastgele bir değer belirleme
        float randomX = Random.Range(-8f, 12f);

        // Yeni bir vektör oluşturarak objeyi spawn etme
        Vector3 spawnPosition = new Vector3(randomX, 11f, 0f);
        Instantiate(objecttToSpawn, spawnPosition, Quaternion.identity);

        // Bu satırı ekleyerek sadece bir obje spawn etmesini sağlayabilirsiniz.
        enabled = false;
    }
}
