using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hasira : MonoBehaviour
{
    public float Z_Speed;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Z_Speed);

        if (transform.position.z < -10)
        {
            transform.position = startPos;
        }
    }
}
