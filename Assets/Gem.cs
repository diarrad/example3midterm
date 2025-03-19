using UnityEngine;

public class Gem : MonoBehaviour
{
    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    
    public float speedBoost = 3f;
    public float duration = 3f;
    public GameObject GemPrefab;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Gem triggered with:" + other.gameObject.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Gem Collected ! Speed increased.");
            Player player = other.gameObject.GetComponent<Player>();
            if (player != null)
            {
                player.Speed += speedBoost;
                Invoke("ResetSpeed", duration);
            }
            Vector2 randomPos = new Vector2(Random.Range(-8.0f, 8.0f), Random.Range(-4.0f, 4.0f));
            Instantiate(GemPrefab, randomPos, Quaternion.identity);
            Destroy(gameObject);
             
        }
        
        
    }

    void ResetSpeed()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            player.GetComponent<Player>().Speed -= speedBoost;
        }
    }

    
    
}
    
    
        
    

