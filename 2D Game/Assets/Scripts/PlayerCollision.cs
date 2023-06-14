
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   
    public int Score = 0;
    [SerializeField] UIManager UIManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            Debug.Log("ACTIVE");
            Score++;
            UIManager.ScoreTextUpdate();
            Destroy(collision.gameObject);
        }
    }

    

}
