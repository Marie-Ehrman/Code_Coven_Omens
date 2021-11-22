using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;
    int letterCount = 1;
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;

        {
            index = 0;
            StartCoroutine(TypeLine());
        }
    }

        // Update is called once per frame
        void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                startButton.gameObject.SetActive(true);
            }
        }

            if (letterCount == lines[index].ToCharArray().Length) {
                startButton.gameObject.SetActive(true);
            }
        }
        IEnumerator TypeLine()
        {
            foreach (char c in lines[index].ToCharArray())
            {
   
                letterCount++;
                textComponent.text += c;
                yield return new WaitForSeconds(textSpeed);
            }
        }
        void NextLine()
        {

            if (index < lines.Length - 1)
            {
                index++;
                textComponent.text = string.Empty;
                StartCoroutine(TypeLine());

            }
            else
            {
                gameObject.SetActive(false);
            }

        }

        void StartButton()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }


     