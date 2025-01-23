using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot1 : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float force;

    void Start()
    {
        Debug.Log("GameManager");



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var b = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            b.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * force);
        }
    }
}
