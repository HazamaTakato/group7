using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyuBullet : MonoBehaviour
{
    public float bulletSpeed;

    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
        if(bulletSpeed < 2f)
        {
            bulletSpeed *= 1.05f;
        }
        if (Time.timeScale == 0f)
        {
            Destroy(gameObject);
        }

    }
}
