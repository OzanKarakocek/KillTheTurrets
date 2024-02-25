using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmaninMermisi : MonoBehaviour
{
    public int damage = 10; // Mermi hasar�

    private void OnTriggerEnter(Collider other)
    {
        // �arp��an nesneyi al
        GameObject hitObject = other.gameObject;

        // E�er �arp��an nesne bir oyuncu ise
        if (hitObject.CompareTag("Player"))
        {
            // Oyuncunun sa�l�k bile�enine zarar ver
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
