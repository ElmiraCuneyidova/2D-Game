
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f; // Zıplama kuvveti
    private bool isJumping = false; // Zıplama durumu
    private Rigidbody2D rb;
    public float moveSpeed = 5f; // Karakterin hareket hızı

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Yatay girişi al
        float horizontalInput = Input.GetAxis("Horizontal");

        // Pozisyonu güncelle
        transform.position += new Vector3(1f, 0f) * moveSpeed * Time.deltaTime ;

        if (Input.GetKeyUp(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
            Debug.Log("ljhbfgle");
        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
