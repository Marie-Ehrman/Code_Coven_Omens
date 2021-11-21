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
    public Collider endGame;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        omensCounter.text = "OMENS: " + omens.ToString() + " / 5";

    }

    public void IncreaseOmens()

    {
        omens++;

    }

    void OnTriggerEnter(Collider collider) {
        print("GAME OVER");
        if (omens == 5) {
            print("GAME OVER");
        }
    }
}
