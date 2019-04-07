using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public int iorn = 0;

    public int shiplevel = 1;

    public int iornprice = 1000;

    public GameObject homebase;

    private Rigidbody2D rb;

    public Animator anim;

    public float maxVelocity = 1;

    public float rotationSpeed = 2;

    #region Monobehavior API;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        float xAxis = Input.GetAxis("Horizontal");
        ThrustForward(yAxis);
        Rotate(transform, xAxis * rotationSpeed);

        if(Input.GetKey(KeyCode.U))
        {
            if(iorn>=iornprice)
            {
                iorn -= iornprice;
                ++shiplevel;
            }
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        { anim.SetBool("isMove", true); }
        else
        { anim.SetBool("isMove", false); }
        CheckLevel();

    }

    void CheckLevel()
    {
        if (shiplevel == 1)
        {
            iornprice = 1000;
        }
        if(shiplevel == 2)
        {
            iornprice = 2000;
            maxVelocity = 2;
            rotationSpeed = 3;
        }
        if(shiplevel == 3)
        {
            iornprice = 5000;
            maxVelocity = 2.5f;
            rotationSpeed = 3.5f;
        }
    }

    #endregion


    #region Maneuvering API

    private void ClampVelocity()
    {
        float x = Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity);
        float y = Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity);

        rb.velocity = new Vector2(x, y);
    }

    private void ClampRotation()
    {
        float rot = Mathf.Clamp(rb.rotation, -3, 3);

        rb.rotation = rot;
    }

    private void ThrustForward(float amount)
    {
        Vector2 force = transform.right * amount;

        rb.AddForce(force);
    }

    private void Rotate(Transform t, float amount)
    {
        if(Input.GetAxis("Vertical") < 0) {
            t.Rotate(0, 0, 0);
        } else
        {
            t.Rotate(0, 0, -amount);
        }
    }

    #endregion

}