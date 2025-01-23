using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform destionation;
    public GameObject bridge;


    private Coroutine teleportCoroutine;





    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.gameObject.tag == "Portal")
    //    {
    //        TeleportPlayer();
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.gameObject.tag == "Portal")
        {
            teleportCoroutine = StartCoroutine(TimeBeforeTeleport(3));
            
        }
    }

  

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        if (other.gameObject.tag == "Portal")
        {
            if (teleportCoroutine != null)
            {
                StopCoroutine(teleportCoroutine);
            }
        }
    }

    IEnumerator TimeBeforeTeleport(float teleportTime)
    {
        yield return new WaitForSeconds(teleportTime);
        TeleportPlayer();
    }
    void TeleportPlayer()
    {
        transform.position = destionation.position;
    }


    


}
