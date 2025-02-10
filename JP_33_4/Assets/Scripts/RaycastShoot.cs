using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShoot : MonoBehaviour
{
    public float shootDistance;
    public GameObject particlePlaceHolder;
    public float delayTime;
    private float previouseTime;
    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, shootDistance) &&
            Input.GetKeyDown(KeyCode.Mouse0) && CheckDelay())
        {
            
            var hitpoint = hitInfo.point;
            Instantiate(particlePlaceHolder, hitpoint, Quaternion.identity);
        }

    }

    private bool CheckDelay()
    {
        if (previouseTime == 0)
        {
            previouseTime = Time.time;
            return true;
        }
        if (Time.time - previouseTime > delayTime)
        {
            previouseTime = Time.time;
            return true;
        }
        else
        {
            return false;
        }
    }
}
