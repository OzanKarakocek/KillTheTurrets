using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KarakterSaglik : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public int can = 100; // Baþtaki can miktarýnýzý ayarlayýn
    public float yenidenBaslamaZamanlayýcý = 2f; // Yeniden baþlama zamanlayýcýsý

    private bool yenidenBaslat = false;
    private float gecenSure = 0f;

    public Text healthText; // Saðlýk miktarýný göstermek için bir UI metni

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

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
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Ölüm iþlemleri buraya gelebilir
        Debug.Log("Öldünüz!");
        // Örneðin: Oyunu yeniden baþlatma
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void UpdateHealthUI()
    {
        // Saðlýk UI metnini güncelle
        healthText.text = "Saðlýk: " + currentHealth.ToString();
    }
}
