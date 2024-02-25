using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanSaldırı : MonoBehaviour
{
    public Transform playerTransform; // Oyuncunun transformu
    public GameObject bulletPrefab; // Mermi objesinin referansı
    public Transform shootPoint; // Mermilerin başlangıç noktası

    public float shootInterval = 2f; // Mermi atış aralığı
    private float shootTimer;

    public float bulletSpeed = 10f; // Mermi hızı
    public int damage = 10; // Mermi hasarı

    void Update()
    {
        // Her shootInterval süresince ateş et
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0f;
        }
    }

    void Shoot()
    {
        // Mermiyi oluştur
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        // Mermiye hedef belirle
        Vector3 shootDirection = (playerTransform.position - transform.position).normalized;

        // Mermiye hız ver
        bullet.GetComponent<Rigidbody>().velocity = shootDirection * bulletSpeed;

        // Mermiye hasar verme bilgisi ekle
        bullet.GetComponent<DusmaninMermisi>().damage = damage;
    }
}
