using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLights : MonoBehaviour
{

    public Light lights;
    public bool isFlickering = false;
    public float timeDelay;


    // Update is called once per frame
    void Update()
    {



        if (isFlickering == false) {
            StartCoroutine(FlickeringLight());
        }

    }

    IEnumerator FlickeringLight() {
        lights = GetComponent<Light>();

        isFlickering = true;
        lights.enabled = false;

        timeDelay = Random.Range(0.01f, 0.5f);
        yield return new WaitForSeconds(timeDelay);

        lights.enabled = true;
        timeDelay = Random.Range(0.01f, 0.5f);
        yield return new WaitForSeconds(timeDelay);

        isFlickering = false;
    }
}
