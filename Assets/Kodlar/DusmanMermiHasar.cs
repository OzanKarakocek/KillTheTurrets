using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanMermiHasar : MonoBehaviour
{
    public float bulletDamage = 10f; // Mermi hasar�

    void OnTriggerEnter(Collider other)
    {
        // �arpt���m�z nesnenin bir oyuncu olup olmad���n� kontrol edelim
        KarakterSaglik playerHealth = other.GetComponent<KarakterSaglik>();
        if (playerHealth != null)
        {
            // Oyuncunun sa�l���na mermi hasar�n� uygula
            playerHealth.TakeDamage(bulletDamage);
        }

        // Mermiyi yok et
        Destroy(gameObject);
    }
}
