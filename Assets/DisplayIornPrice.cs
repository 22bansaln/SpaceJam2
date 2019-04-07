using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayIornPrice : MonoBehaviour
{
    public Text IPrice;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        setPrice();
    }
    void setPrice()
    {
        IPrice.text = "Next Level Cost: " + GameObject.FindWithTag("Player").GetComponent<ShipControl>().iornprice + " IOrN";
    }
}
