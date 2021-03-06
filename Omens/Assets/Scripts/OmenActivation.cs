using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OmenActivation : MonoBehaviour
{
    bool isActive;
    bool stopCounting;

    public GameObject activationPrimer;
    public GameManager gameManager;
    

    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == false)

        {
            if (activationPrimer.GetComponent<MeshRenderer>() != null && activationPrimer.GetComponent<MeshRenderer>().enabled == true)

            {
                GetComponent<MeshRenderer>().enabled = true;
                gameManager.IncreaseOmens();
                isActive = true;
            }

            else if (activationPrimer.GetComponent<MeshRenderer>() == null && activationPrimer.GetComponent<SkinnedMeshRenderer>() != null && activationPrimer.GetComponent<SkinnedMeshRenderer>().enabled == true)
            {
                GetComponent<SkinnedMeshRenderer>().enabled = true;
                gameManager.IncreaseOmens();
                isActive = true;
            }

            else if (activationPrimer.GetComponent<MeshRenderer>() == null && activationPrimer.GetComponent<SkinnedMeshRenderer>() == null && activationPrimer.GetComponent<SpriteRenderer>() != null && activationPrimer.GetComponent<SpriteRenderer>().enabled == true)
            {
                GetComponent<SpriteRenderer>().enabled = true;
                gameManager.IncreaseOmens();
                isActive = true;
            }

        }

    }

     
}
