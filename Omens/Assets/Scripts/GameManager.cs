using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public int omens;
    public int luckStat;
    public int sanityStat;

    public Text omensCounter;
    public Text timer;
    public float globalTimer = 180;

    public Collider endGame;
    public GameOver GameOver;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        omensCounter.text = "OMENS: " + omens.ToString() + " / 5";
        timer.text = "TIME:  " + globalTimer.ToString();

        TimerClock();

    }

    public void IncreaseOmens()

    {
        omens++;

    }

    public void GameOverScreen() {
        GameOver.Setup();
    }

    void TimerClock() {
        globalTimer -= Time.deltaTime;
        timer.text = "TIME:  " +  Mathf.Round(globalTimer).ToString();
    }


}
