using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameOver : MonoBehaviour
{
    public void Setup() {
        gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
