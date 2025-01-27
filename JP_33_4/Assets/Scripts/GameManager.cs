using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject Player;



    private void Start()
    {
        Player.transform.position = spawnPoints[PlayerPrefs.GetInt("Level")].position;
    }



}
