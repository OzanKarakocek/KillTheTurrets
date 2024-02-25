using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontrol : MonoBehaviour
{
    void Start()
    {
        MuzikKontrol.instance.PlayMusic(); // Oyun ba�lad���nda m�zi�i �al
    }

    void Update()
    {
        // �stenmeyen sahne veya ko�ullara g�re m�zi�i duraklat/duraklatma
        if (SceneManager.GetActiveScene().name == "YeniBolum")
        {
           MuzikKontrol.instance.PauseMusic();
        }
        else
        {
            MuzikKontrol.instance.ResumeMusic();
        }
    }

    // Sahne de�i�ti�inde m�zi�i devam ettir
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        MuzikKontrol.instance.ResumeMusic();
    }
}
