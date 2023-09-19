using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveAndLoad
{
    public float health;
    public float[] playerPos;

    public SaveAndLoad (PlayerStats player)
    {
        health = player.playerHealth;
        playerPos = new float[3];
        playerPos[0] = player.transform.position.x;
        playerPos[1] = player.transform.position.y;
        playerPos[2] = player.transform.position.z;

    }
    
    
}
