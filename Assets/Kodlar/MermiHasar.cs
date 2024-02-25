using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiHasar : MonoBehaviour
{
    public float bulletDamage = 10f; // Mermi hasar�

    void OnTriggerEnter(Collider other)
    {
        // �arpt���m�z nesnenin bir d��man olup olmad���n� kontrol edelim
        DusmanSaglik enemyHealth = other.GetComponent<DusmanSaglik>();
        if (enemyHealth != null)
        {
            // D��man sa�l���na mermi hasar�n� uygula
            enemyHealth.TakeDamage(bulletDamage);
        }

        // Mermiyi yok et
        Destroy(gameObject);
    }
}
