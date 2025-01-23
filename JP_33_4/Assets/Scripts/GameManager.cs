using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float startTime = 50;



    private void Start()
    {
        StartCoroutine(timer());
    }



    IEnumerator timer()
    {
        while (startTime != 0)
        {
            yield return new WaitForSeconds(1);
            startTime--;
            // Debug.Log(startTime);
        }
    }

}
