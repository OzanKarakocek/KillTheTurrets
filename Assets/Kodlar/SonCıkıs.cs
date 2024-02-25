using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonCıkıs : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Karakter objesinin belirlediğiniz obje ile temasını algıla
        if (other.CompareTag("GeçişObjesi"))
        {
            // Diğer sahneye geç
            SceneManager.LoadScene("DevamEdecek");
        }
    }
}
