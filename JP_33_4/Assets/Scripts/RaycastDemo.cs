using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{


    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {

            Debug.Log(hit.transform.name);
        }
        else
        {
            Debug.Log("agar exeba");
        }
    }



}
