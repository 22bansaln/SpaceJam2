using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class CollisionDeath : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Border"&&gameObject.tag == "Player")
        {
            StartCoroutine("wait");
        }
        if (collision.gameObject.tag == "Asteroid" && gameObject.tag == "Player")
        {
            StartCoroutine("wait");
        }
        if (collision.gameObject.tag == "Laser" && gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameObject.FindWithTag("Player").GetComponent<ShipControl>().iorn += RandomNumber(100,500);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        rend.enabled = true;
        yield return new WaitForSeconds(1.5f);
        Destroy(player);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public int RandomNumber(int min, int max)
    {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
