using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLaser : MonoBehaviour
{
    public GameObject player;
    public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //Vector3 playposition = new Vector3(player.transform.position.x, player.transform.position.y, -4);
            Vector3 ObjectSpawnPosition = player.transform.position + (player.transform.right);
            var obj = Instantiate(laser, ObjectSpawnPosition, player.transform.rotation);
            obj.SetActive(true);
        }
    }
}
