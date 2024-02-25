using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    public GameObject bulletPrefab; // Mermi objesinin referans�
    public Transform firePoint; // ate� noktas�n�n referans�
    public float bulletSpeed = 20f; // Mermi h�z�

    void Update()
    {
        // Mouse sol t�k alg�lama
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(); // Ate� fonksiyonunu �a��r
        }
    }

    void Shoot()
    {
        // Mermi objesini ate� noktas�ndan olu�tur
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Mermiye h�z ver
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;
    }
}
