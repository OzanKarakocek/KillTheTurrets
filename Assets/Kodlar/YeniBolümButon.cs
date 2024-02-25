using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YeniBolümButon : MonoBehaviour
{
    public void GoToNextLevel()
    {
        // İlgili sahneye geçiş yapılır (örneğin, 2. sahne için "Level2" yazabilirsiniz)
        SceneManager.LoadScene("SampleScene");
    }
}
