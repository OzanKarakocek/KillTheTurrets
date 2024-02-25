using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Karakter objesinin belirlediðiniz obje ile temasýný algýla
        if (other.CompareTag("GeçiþObjesi"))
        {
            // Diðer sahneye geç
            SceneManager.LoadScene("YeniBolum");
        }
    }
}
