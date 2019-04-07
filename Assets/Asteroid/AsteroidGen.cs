using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGen : MonoBehaviour
{

    public GameObject Asteroid;
    public GameObject Camera;

    private float xPos;
    private float yPos;
    private float xRot;
    private float yRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnAsteroid();
    }

    #region Asteroid Generation

    void SpawnAsteroid()
    {
        int placeholder = Random.Range(1, 2);
        float tempX = Camera.transform.position.x;
        float tempY = Camera.transform.position.y;
        xPos = Random.Range(-99, 150);
        yPos = Random.Range(-78, 160);
        xRot = Random.Range(-180, 180);
        yRot = Random.Range(-180, 180);
        /*if (placeholder <= 1) {
            xPos = Random.Range(tempX + 50, tempX + 100);
            yPos = Random.Range(tempY + 50, tempY + 100);
        } else {
            xPos = Random.Range(tempX - 50, tempX - 100);
            yPos = Random.Range(tempY - 50, tempY - 100);
        }*/
        int placeholder2 = Random.Range(1, 100);
        if(placeholder2 <= 2) {
            if(GameObject.FindGameObjectsWithTag("Asteroid").Length<100)
            {
                Vector3 ObjectSpawnPostion = new Vector3(xPos, yPos, -3);
                var obj = Instantiate(Asteroid, ObjectSpawnPostion, transform.rotation);
                obj.SetActive(true);
            }
        }
    }

    #endregion


}
