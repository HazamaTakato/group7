using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullettwelve : MonoBehaviour
{
    float bulletSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
    }
}
