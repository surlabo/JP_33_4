using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeConstructor : MonoBehaviour
{
    public GameObject Brigde;






    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bridge")
        {
            Brigde.SetActive(true);
        }
    }
}
