using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRaycast : MonoBehaviour
{

    void Update()
    {
        //GetComponent<Rigidbody>().AddTorque(15f, 0, 15f);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward * 20), Color.green);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 30f))
        {
            Debug.Log($"Hit2 {hitInfo.collider.gameObject.tag}");
            if (hitInfo.collider.tag == "Enemy")
            {
                hitInfo.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
                hitInfo.collider.gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
