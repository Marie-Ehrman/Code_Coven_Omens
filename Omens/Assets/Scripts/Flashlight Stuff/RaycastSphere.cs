using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastSphere : MonoBehaviour
{
    public GameObject currentHitObject;

    public float sphereRadius;
    public float maxDistance;
    public LayerMask layerMask;

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

            if (hit.collider.CompareTag("Interactable"))
            {
                hit.collider.SendMessage("HitByLight");

            }

            if (hit.collider.CompareTag("Interactable") && Input.GetButton("Fire1"))
            {
                hit.collider.GetComponent<MeshRenderer>().enabled = true;
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
