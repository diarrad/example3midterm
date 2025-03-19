using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CoinScript : MonoBehaviour
{
    public static int coinCount = 0;
    public int totalCoins;
    public int coinsCollected;
    
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log(" Coin collected !");
            coinCount++;
            

            //This destroys the coin
            Destroy(gameObject);
            
        }
    }

    public void CollectCoin()
    {
        coinsCollected++;
        if (coinsCollected >= totalCoins)
        {
            Debug.Log(" You Win !");
            SceneManager.LoadScene("You win");
        }
    }
    
   
}
