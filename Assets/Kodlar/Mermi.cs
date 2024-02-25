using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    public GameObject bulletPrefab; // Mermi objesinin referansý
    public Transform firePoint; // ateþ noktasýnýn referansý
    public float bulletSpeed = 20f; // Mermi hýzý

    void Update()
    {
        // Mouse sol týk algýlama
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot(); // Ateþ fonksiyonunu çaðýr
        }
    }

    void Shoot()
    {
        // Mermi objesini ateþ noktasýndan oluþtur
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Mermiye hýz ver
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;
    }
}
