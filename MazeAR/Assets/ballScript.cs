using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public GameObject floor;
    public GameObject spawnPoint;
    //Allows the reset point for the game to be moved closer or further from the bottomm of the stage
    public int RespawnDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the Spawn point and the plane for the ball
        //Respawns the ball if it falls below the maze
        if(transform.position.y < floor.transform.position.y - RespawnDistance)
        {
            transform.position = spawnPoint.transform.position;
        }
    }
}
