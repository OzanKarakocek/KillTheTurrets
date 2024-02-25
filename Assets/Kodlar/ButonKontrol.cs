using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButonKontrol : MonoBehaviour
{
    // Oyuna baþla butonuna týklanýnca çaðrýlacak fonksiyon
    public void StartGame()
    {
        // Ýlgili sahneye geçiþ yapýlýr (örneðin, 1. sahne için "SampleScene" yazabilirsiniz)
        SceneManager.LoadScene("Hikaye");
    }

    // Oyundan çýk butonuna týklanýnca çaðrýlacak fonksiyon
    public void QuitGame()
    {
        // Uygulama kapatýlýr (bu sadece çalýþýr durumda olan bir build'da çalýþýr, editörde çalýþmaz)
        Application.Quit();
    }
}
