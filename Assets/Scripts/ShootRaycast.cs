using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRaycast : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private LayerMask _layerMask;

    void Update()
    {
        Debug.DrawRay(shootPoint.transform.position, 
            transform.forward * 20f, Color.green);
        
        if (Physics.Raycast(shootPoint.transform.position, 
            transform.forward, out RaycastHit hitInfo, 
            20f, _layerMask))
        {
            Debug.Log($"Hit {hitInfo.collider.gameObject.tag}!");
            //alternative code for transform.forward
            Debug.DrawRay(shootPoint.transform.position, 
                          transform.TransformDirection(Vector3.forward) * hitInfo.distance, 
                          Color.red );
        }
        else
        {
            Debug.Log("hit nothing.");
        }
    }
}


