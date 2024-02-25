using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanSaglik : MonoBehaviour
{
    public float maxHealth = 100f; // D��man�n maksimum sa�l�k de�eri
    private float currentHealth; // D��man�n mevcut sa�l�k de�eri
    public DusmanKontrol enemyManager; // D��man y�neticisi




    void Start()
    {
        currentHealth = maxHealth; // Ba�lang��ta d��man�n sa�l���n� maksimum sa�l�k de�eri ile ayarla
        enemyManager = FindObjectOfType<DusmanKontrol>();
        enemyManager = GameObject.FindObjectOfType<DusmanKontrol>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            // D��man �ld�r�ld���nde EnemyManager'daki KillEnemy fonksiyonunu �a��r
            enemyManager.KillEnemy();
            // D��man� yok et
            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // Gelen hasar� d��man�n sa�l���ndan ��kar

        if (currentHealth <= 0)
        {
            Die(); // D��man�n sa�l��� s�f�ra ula�t���nda �l
        }
    }

    void Die()
    {
        
        // D��man� yok et
        Destroy(gameObject);
        
    }
}
