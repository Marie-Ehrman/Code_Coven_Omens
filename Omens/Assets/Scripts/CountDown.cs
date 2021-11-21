using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    public float globalTimer = 180;


    public Text globalTimeTextBox;




    // Start is called before the first frame update
    void Start()
    {
        globalTimeTextBox.text = globalTimer.ToString();


    }
    // Update is called once per frame
    void Update()
    {

        globalTimer -= Time.deltaTime;
        globalTimeTextBox.text = Mathf.Round(globalTimer).ToString();


    }

}
