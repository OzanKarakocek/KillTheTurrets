using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HikayeDevamButonu : MonoBehaviour
{
    // Bir sonraki sahneye geçiþ yapacak butona týklanýnca çaðrýlacak fonksiyon
    public void GoToNextLevel()
    {
        // Ýlgili sahneye geçiþ yapýlýr (örneðin, 2. sahne için "Level2" yazabilirsiniz)
        SceneManager.LoadScene("Sahne2");
    }
}
