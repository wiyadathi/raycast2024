using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private LayerMask _layerMask;

    void Update()
    {
        if (Physics.Raycast(shootPoint.transform.position, transform.TransformDirection(Vector3.forward),
            out RaycastHit hitInfo, 20f, _layerMask))
        {
            Debug.Log($"Hit {hitInfo.collider.gameObject.tag}!");
            Debug.DrawRay(shootPoint.transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red );
        }
        else
        {
            Debug.Log("hit nothing.");
            Debug.DrawRay(shootPoint.transform.position, transform.TransformDirection(Vector3.forward) * 20f, Color.green);
        }
    }
}
