using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject Player;
    public Teleport tp;



    private void Start()
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            var id = PlayerPrefs.GetInt("Level");
            Player.transform.position = spawnPoints[id].position;
        }
    }
}

