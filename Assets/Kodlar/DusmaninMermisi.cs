using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmaninMermisi : MonoBehaviour
{
    public int damage = 10; // Mermi hasarý

    private void OnTriggerEnter(Collider other)
    {
        // Çarpýþan nesneyi al
        GameObject hitObject = other.gameObject;

        // Eðer çarpýþan nesne bir oyuncu ise
        if (hitObject.CompareTag("Player"))
        {
            // Oyuncunun saðlýk bileþenine zarar ver
            KarakterSaglik playerHealth = hitObject.GetComponent<KarakterSaglik>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            // Mermiyi yok et
            Destroy(gameObject);
        }
    }
}
