using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunBitti : MonoBehaviour
{
    public int can = 100; // Baþtaki can miktarýnýzý ayarlayýn
    public float yenidenBaslamaZamanlayýcý = 2f; // Yeniden baþlama zamanlayýcýsý

    private bool yenidenBaslat = false;
    private float gecenSure = 0f;

    // Her frame'de kontrol edilmesi gereken iþlemler için Update fonksiyonunu kullanacaðýz
    void Update()
    {
        if (can <= 0)
        {
            yenidenBaslat = true; // can 0'a düþtüðünde yeniden baþlat bayraðýný aç
        }

        if (yenidenBaslat)
        {
            gecenSure += Time.deltaTime; // süreyi kaydet
            if (gecenSure >= yenidenBaslamaZamanlayýcý)
            {
                YenidenBaslat(); // Yeniden baþlama zamanlayýcýsý aþýldýysa oyunu yeniden baþlat
            }
        }
    }

    void YenidenBaslat()
    {
        // Eðer yeniden baþlat bayraðý açýksa ve zamanlayýcý aþýldýysa sahneyi yeniden baþlat
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
