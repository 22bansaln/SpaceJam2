using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class LaserMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 1000000000000000.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("wait");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
