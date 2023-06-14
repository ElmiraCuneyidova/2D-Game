
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    //public int scoreValue = 10; // Her coin'in değeri

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        // Coin'e dokunulduğunda puanı güncelle
    //        GameManager.instance.AddScore(scoreValue);

    //        // Coin'i yok et
    //        Destroy(gameObject);
    //    }
    //}


    public int scoreValue = 10; // Her coin'in değeri

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            // Coin'e dokunulduğunda puanı güncelle
            ScoreManager.instance.UpdateScore(scoreValue);

            // Coin'i yok et
            Destroy(gameObject);
        }
    }
}

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton instance
    private int score = 0; // Puan değişkeni

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void UpdateScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score); // Puanı konsola yazdırabilirsiniz
    }






}
