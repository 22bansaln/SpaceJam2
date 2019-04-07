using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayShipLevel : MonoBehaviour
{
    public Text SLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setLevel();
    }
    void setLevel()
    {
        SLevel.text = "Ship Level: " + GameObject.FindWithTag("Player").GetComponent<ShipControl>().shiplevel;
    }
}
