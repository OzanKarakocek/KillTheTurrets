using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Karakter objesinin belirledi�iniz obje ile temas�n� alg�la
        if (other.CompareTag("Ge�i�Objesi"))
        {
            // Di�er sahneye ge�
            SceneManager.LoadScene("YeniBolum");
        }
    }
}
