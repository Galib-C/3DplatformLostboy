using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
