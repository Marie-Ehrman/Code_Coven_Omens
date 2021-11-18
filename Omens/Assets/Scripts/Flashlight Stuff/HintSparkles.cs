using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintSparkles : MonoBehaviour
{

    ParticleSystem sparkles;
    MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        sparkles = GetComponent<ParticleSystem>();
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HitByLight()
    {
        if (mr.enabled == false)
        {
            sparkles.Play();
        }

        else if (mr.enabled == true)
        {
            sparkles.Stop();
        }
    }
}
