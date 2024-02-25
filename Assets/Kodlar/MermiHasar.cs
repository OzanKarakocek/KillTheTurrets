using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiHasar : MonoBehaviour
{
    public float bulletDamage = 10f; // Mermi hasarý

    void OnTriggerEnter(Collider other)
    {
        // Çarptýðýmýz nesnenin bir düþman olup olmadýðýný kontrol edelim
        DusmanSaglik enemyHealth = other.GetComponent<DusmanSaglik>();
        if (enemyHealth != null)
        {
            // Düþman saðlýðýna mermi hasarýný uygula
            enemyHealth.TakeDamage(bulletDamage);
        }

        // Mermiyi yok et
        Destroy(gameObject);
    }
}
