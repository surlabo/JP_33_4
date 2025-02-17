using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RaycastDemo : MonoBehaviour
{
    private LayerMask mask;

    void Update()
    {
        mask = (1 << 3) | (1 << 5);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 100, mask))
        {
            Debug.Log(hit.transform.name);
        }
        else
        {
            //Debug.Log("agar exeba");
        }
    }

    public int MyMethod(ref int secondInfo)
    {
        secondInfo = 10;
        return 1;
    }




}
