using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuyeDon : MonoBehaviour
{
    public void GoToNextLevel()
    {
        // �lgili sahneye ge�i� yap�l�r (�rne�in, 2. sahne i�in "Level2" yazabilirsiniz)
        SceneManager.LoadScene("Menu");
    }
}
