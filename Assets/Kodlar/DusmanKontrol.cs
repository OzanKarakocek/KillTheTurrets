using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanKontrol : MonoBehaviour
{
    public int totalEnemies = 10; // Ba�lang��ta toplam d��man say�s�
    public Text enemyCountText; // D��man say�s�n� g�sterecek metin alan�

    void Start()
    {
        UpdateEnemyCountText(); // Metin alan�n� ba�lang��ta g�ncelleyin
    }

    // D��man �ld�rme fonksiyonu
    public void KillEnemy()
    {
        totalEnemies--; // D��man say�s�n� azalt
        UpdateEnemyCountText(); // Metin alan�n� g�ncelle
    }

    // Metin alan�n� g�ncelleyen fonksiyon
    void UpdateEnemyCountText()
    {
        enemyCountText.text = "D��man Say�s�: " + totalEnemies.ToString(); // Metin alan�n� g�ncelle
    }
}
