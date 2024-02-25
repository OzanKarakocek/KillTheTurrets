using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonKontrol : MonoBehaviour
{
    // Oyuna ba�la butonuna t�klan�nca �a�r�lacak fonksiyon
    public void StartGame()
    {
        // �lgili sahneye ge�i� yap�l�r (�rne�in, 1. sahne i�in "SampleScene" yazabilirsiniz)
        SceneManager.LoadScene("Hikaye");
    }

    // Oyundan ��k butonuna t�klan�nca �a�r�lacak fonksiyon
    public void QuitGame()
    {
        // Uygulama kapat�l�r (bu sadece �al���r durumda olan bir build'da �al���r, edit�rde �al��maz)
        Application.Quit();
    }
}
