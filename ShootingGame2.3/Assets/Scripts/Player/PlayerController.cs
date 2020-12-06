using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject MOP;
    public Vector3 MOPTrans;
    Vector3 direction;
    public float speed;
    float x = 0f;
    float y = 0f;

    Rigidbody rb;

    Vector3 min;
    Vector3 max;
    public float width;
    public float height;

    public bool yConvert;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        yConvert = false;

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
        if (!YConvert())
        {
            direction = (new Vector3(x, y, 0).normalized) * speed;
        }
        else
        {
            direction = (new Vector3(x, -y, 0).normalized) * speed;
        }

        Clamp();

    }

    public void FixedUpdate()
    {
        
        rb.velocity = direction;
    }

    public Vector3 GetMOP()
    {
        return MOPTrans;
    }

    public void Clamp()
    {

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -width, width);
        pos.y = Mathf.Clamp(pos.y, -2, height);

        transform.position = pos;
    }
    private bool YConvert()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            yConvert = !yConvert;
        }
        return yConvert;
    }

    public Vector3 Velocity()
    {
        return rb.velocity;
    }

    public Vector3 Pos()
    {
        return transform.position;
    }

}
