using UnityEngine;
using System.Collections;

public class SpeedBoost : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float boostAmount = 3f;
    public float spawnRangeX = 5f; // x-axis spawn range
    public float spawnRangeY = 5f; // y-axis spawn range
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerScript>().Speed += boostAmount;
            Respawn(); // move gem after collection 
        }

        void Respawn()

        {
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            float randomY = Random.Range(-spawnRangeY, spawnRangeY);
            transform.position = new Vector3(randomX, transform.position.y, transform.position.z);
        }
    }
}
