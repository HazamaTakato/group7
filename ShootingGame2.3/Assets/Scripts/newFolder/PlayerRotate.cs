using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    Quaternion playerRota;
    float rotateX;
    public float rotateZ;
    public float angle;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRota = Quaternion.Euler(rotateX, 0f, rotateZ);

        if (rb.velocity.x >= 0.1f)
        {
            if (rotateZ > -angle)
            {
                rotateZ -= 1;
                transform.rotation = playerRota;
            }
            return;
        }
        else if (rb.velocity.x <= -0.1f)
        {
            if (rotateZ < angle)
            {
                rotateZ += 1;
                transform.rotation = playerRota;
            }
            return;
        }
        else
        {
            if (rotateZ != 0)
            {
                rotateZ -= Mathf.Sign(rotateZ);
                transform.rotation = playerRota;
            }
        }
        if (rb.velocity.y >= 0.1f)
        {
            if (rotateX > -angle)
            {
                rotateX -= 1;
                transform.rotation = playerRota;
            }
            return;
        }
        else if (rb.velocity.y <= -0.1f)
        {
            if (rotateX < angle)
            {
                rotateX += 1;
                transform.rotation = playerRota;
            }
            return;
        }
        else
        {
            if (rotateX != 0)
            {
                rotateX -= Mathf.Sign(rotateX);
                transform.rotation = playerRota;
            }
        }
        if(Time.timeScale == 0f)
        {
            rb.velocity = new Vector3(0, 0);
        }
    }
}
