using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSphere : MonoBehaviour
{
    public GameObject currentHitObject;

    public float sphereRadius;
    public float maxDistance;
    public LayerMask layerMask;

    public int lightDamage = 1;

    private Vector3 origin;
    private Vector3 direction;

    private float currentHitDistance;

    void Start()
    {
        
    }

    void Update()
    {
        origin = transform.position;
        direction = transform.forward;
        RaycastHit hit;

        if (Physics.SphereCast(origin, sphereRadius, direction, out hit, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal))
        {
            currentHitObject = hit.transform.gameObject;
            currentHitDistance = hit.distance;

            LightHit health = hit.collider.GetComponent<LightHit>();


            if (health != null)
            {
                health.Damage(lightDamage);
            }



        }

        else
        {
            currentHitDistance = maxDistance;
            currentHitObject = null;
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Debug.DrawLine(origin, origin + direction * currentHitDistance);
        Gizmos.DrawWireSphere(origin + direction * currentHitDistance, sphereRadius);
    }
}
