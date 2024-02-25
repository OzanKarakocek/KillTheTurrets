using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanMermiHasar : MonoBehaviour
{
    public float bulletDamage = 10f; // Mermi hasarý

    void OnTriggerEnter(Collider other)
    {
        // Çarptýðýmýz nesnenin bir oyuncu olup olmadýðýný kontrol edelim
        KarakterSaglik playerHealth = other.GetComponent<KarakterSaglik>();
        if (playerHealth != null)
        {
            // Oyuncunun saðlýðýna mermi hasarýný uygula
            playerHealth.TakeDamage(bulletDamage);
        }

        // Mermiyi yok et
        Destroy(gameObject);
    }
}
