using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeBulletEnemyBullet : MonoBehaviour
{
    float bulletSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
        if (Time.timeScale == 0f)
        {
            Destroy(gameObject);
        }

    }
}
