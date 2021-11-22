using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameOver : MonoBehaviour
{
    [SerializeField]
    public GameManager GameManager;
    public Text gameOverText;


    public void Setup() {
        gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void WinGame() {
        gameOverText.fontSize = 20;
        gameOverText.text = "You have esacped this time...";
    }

    public void LoseGame()
    {
        gameOverText.text = "You will never esacpe...";
    }
}
