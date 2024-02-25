using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuyeDon : MonoBehaviour
{
    public void GoToNextLevel()
    {
        // Ýlgili sahneye geçiþ yapýlýr (örneðin, 2. sahne için "Level2" yazabilirsiniz)
        SceneManager.LoadScene("Menu");
    }
}
