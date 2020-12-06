using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    public Transform bulletPos;
    public float LeftRight;
    public float DownShadow;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(bulletPos.position.x,transform.position.y - bulletPos.position.y, bulletPos.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bulletPos.position.x + LeftRight,DownShadow, bulletPos.position.z);
    }
}
