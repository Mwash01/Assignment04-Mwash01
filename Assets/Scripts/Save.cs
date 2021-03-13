using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save
{
    public List<Vector2> PinPositions = new List<Vector2>();
    public string playerName;
    public int scoreNum;
    public int playerLives;
    public int totalLives;
    public float rotatorSpeed;
    public float fireSpeed;
    public float timeRemaining;
}
