using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public Text TimePlayed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetTP();
    }
    void SetTP()
    {
        float timer = Time.time;
        TimePlayed.text = "Time Played: " + timer;
    }
}
