using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KarakterSaglik : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public int can = 100; // Ba�taki can miktar�n�z� ayarlay�n
    public float yenidenBaslamaZamanlay�c� = 2f; // Yeniden ba�lama zamanlay�c�s�

    private bool yenidenBaslat = false;
    private float gecenSure = 0f;

    public Text healthText; // Sa�l�k miktar�n� g�stermek i�in bir UI metni

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

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
        // �l�m i�lemleri buraya gelebilir
        Debug.Log("�ld�n�z!");
        // �rne�in: Oyunu yeniden ba�latma
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void UpdateHealthUI()
    {
        // Sa�l�k UI metnini g�ncelle
        healthText.text = "Sa�l�k: " + currentHealth.ToString();
    }
}
