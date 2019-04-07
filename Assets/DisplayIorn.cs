using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayIorn : MonoBehaviour
{
    public Text IornCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setICount();
    }
    void setICount()
    {
        IornCount.text = "IOrN: " + GameObject.FindWithTag("Player").GetComponent<ShipControl>().iorn;
    }
}
