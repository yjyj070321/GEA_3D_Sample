using System;
using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string PlayerName = "UMYEJUN";
    public int level = 20;
    public float attack = 2f;
    public bool isBoss;

    [ContextMenu("Show Stats")]

    void ShowStats()
    {
        Debug.Log("Player Name: " + PlayerName);
        Debug.Log("Level: " + level);
        Debug.Log("Attack: " + attack);
        Debug.Log("Is Boss: " + isBoss);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
