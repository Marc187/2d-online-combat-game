using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    // I want get two spawn points and make it spawn there when someone join the game
    public Transform[] spawnPoints;

    void Start()
    {
        spawnPoints = GetComponentsInChildren<Transform>();
    }

    // When a player join the game, it will spawn at the first spawnpoint then next second 
    // player will spawn at the second spawnpoint
    public Transform GetSpawnPoint()
    {
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        return spawnPoint;
    }




    
}
