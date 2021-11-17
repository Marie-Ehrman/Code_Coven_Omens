using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHit : MonoBehaviour
{
    bool canTakeDamage = true;


    public int currentHealth = 2;
    //private float shaderHealth = 1f;

   public void Damage(int damageAmount)
    {
        //Subtract damage amount when Damage function is called
        if (canTakeDamage)
        {
            StartCoroutine(WaitForSeconds());
            currentHealth -= damageAmount;

        }

        //Check if health has fallen below zero

        if (currentHealth <=0)
        {
            //if hp is <0, deactivate

            Destroy(gameObject, 0.2f);

        }
    }

    IEnumerator WaitForSeconds()
    {
        canTakeDamage = false;
        yield return new WaitForSecondsRealtime(1);
        canTakeDamage = true;
    }
}
