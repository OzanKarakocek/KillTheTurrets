using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HikayeDevamButonu : MonoBehaviour
{
    // Bir sonraki sahneye ge�i� yapacak butona t�klan�nca �a�r�lacak fonksiyon
    public void GoToNextLevel()
    {
        // �lgili sahneye ge�i� yap�l�r (�rne�in, 2. sahne i�in "Level2" yazabilirsiniz)
        SceneManager.LoadScene("Sahne2");
    }
}
