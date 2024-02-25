using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanSaglik : MonoBehaviour
{
    public float maxHealth = 100f; // Düþmanýn maksimum saðlýk deðeri
    private float currentHealth; // Düþmanýn mevcut saðlýk deðeri
    public DusmanKontrol enemyManager; // Düþman yöneticisi




    void Start()
    {
        currentHealth = maxHealth; // Baþlangýçta düþmanýn saðlýðýný maksimum saðlýk deðeri ile ayarla
        enemyManager = FindObjectOfType<DusmanKontrol>();
        enemyManager = GameObject.FindObjectOfType<DusmanKontrol>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            // Düþman öldürüldüðünde EnemyManager'daki KillEnemy fonksiyonunu çaðýr
            enemyManager.KillEnemy();
            // Düþmaný yok et
            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage; // Gelen hasarý düþmanýn saðlýðýndan çýkar

        if (currentHealth <= 0)
        {
            Die(); // Düþmanýn saðlýðý sýfýra ulaþtýðýnda öl
        }
    }

    void Die()
    {
        
        // Düþmaný yok et
        Destroy(gameObject);
        
    }
}
