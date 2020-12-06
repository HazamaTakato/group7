using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossEnemyBullet : MonoBehaviour
{

    public float bulletSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, bulletSpeed);
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
