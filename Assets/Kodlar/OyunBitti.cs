using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunBitti : MonoBehaviour
{
    public int can = 100; // Ba�taki can miktar�n�z� ayarlay�n
    public float yenidenBaslamaZamanlay�c� = 2f; // Yeniden ba�lama zamanlay�c�s�

    private bool yenidenBaslat = false;
    private float gecenSure = 0f;

    // Her frame'de kontrol edilmesi gereken i�lemler i�in Update fonksiyonunu kullanaca��z
    void Update()
    {
        if (can <= 0)
        {
            yenidenBaslat = true; // can 0'a d��t���nde yeniden ba�lat bayra��n� a�
        }

        if (yenidenBaslat)
        {
            gecenSure += Time.deltaTime; // s�reyi kaydet
            if (gecenSure >= yenidenBaslamaZamanlay�c�)
            {
                YenidenBaslat(); // Yeniden ba�lama zamanlay�c�s� a��ld�ysa oyunu yeniden ba�lat
            }
        }
    }

    void YenidenBaslat()
    {
        // E�er yeniden ba�lat bayra�� a��ksa ve zamanlay�c� a��ld�ysa sahneyi yeniden ba�lat
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
