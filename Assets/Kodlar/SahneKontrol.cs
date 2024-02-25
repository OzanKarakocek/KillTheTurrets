using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontrol : MonoBehaviour
{
    void Start()
    {
        MuzikKontrol.instance.PlayMusic(); // Oyun baþladýðýnda müziði çal
    }

    void Update()
    {
        // Ýstenmeyen sahne veya koþullara göre müziði duraklat/duraklatma
        if (SceneManager.GetActiveScene().name == "YeniBolum")
        {
           MuzikKontrol.instance.PauseMusic();
        }
        else
        {
            MuzikKontrol.instance.ResumeMusic();
        }
    }

    // Sahne deðiþtiðinde müziði devam ettir
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        MuzikKontrol.instance.ResumeMusic();
    }
}
