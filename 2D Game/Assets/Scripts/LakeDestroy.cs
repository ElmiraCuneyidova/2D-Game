using UnityEngine;
using UnityEngine.UI;

public class LakeDestroy : MonoBehaviour
{
    public GameObject[] uiImages; // 3 UI resmi
    public Text gameOverText; // Game Over yazısı

    private int destroyedImages = 0; // Yok edilen resim sayısı
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lake")) // Eğer oyuncu göl nesnesine temas ederse
        {
            Destroy(uiImages[destroyedImages]); // İlgili UI resmini yok et
            destroyedImages++;

            if (destroyedImages == 3) // Eğer üçüncü resim yok edildiyse
            {
                gameOverText.gameObject.SetActive(true); // Game Over yazısını aktifleştir
            }
        }
    }


}
