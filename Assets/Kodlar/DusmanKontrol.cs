using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanKontrol : MonoBehaviour
{
    public int totalEnemies = 10; // Baþlangýçta toplam düþman sayýsý
    public Text enemyCountText; // Düþman sayýsýný gösterecek metin alaný

    void Start()
    {
        UpdateEnemyCountText(); // Metin alanýný baþlangýçta güncelleyin
    }

    // Düþman öldürme fonksiyonu
    public void KillEnemy()
    {
        totalEnemies--; // Düþman sayýsýný azalt
        UpdateEnemyCountText(); // Metin alanýný güncelle
    }

    // Metin alanýný güncelleyen fonksiyon
    void UpdateEnemyCountText()
    {
        enemyCountText.text = "Düþman Sayýsý: " + totalEnemies.ToString(); // Metin alanýný güncelle
    }
}
