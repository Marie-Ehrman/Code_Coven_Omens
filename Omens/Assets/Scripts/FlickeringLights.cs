using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLights : MonoBehaviour
{

    public Light lights;



    // Update is called once per frame
    void Update()
    {
        lights = GetComponent<Light>();
            StartCoroutine(FlickeringLight());
        
    }

    IEnumerator FlickeringLight() {
        
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            lights.enabled = !lights.enabled;
        }
    }
}
