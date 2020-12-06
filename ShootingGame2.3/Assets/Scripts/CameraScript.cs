using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;



    private Vector3 offset;

    private Vector3 setPosition;

    //半径

    private float r = 5;

    //ラジアン

    private float rad = 0;

    float horizontal;
    float vertical;

    public GameObject CameraMoveObj;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;

        transform.position += offset;
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal = Input.GetAxis("Mouse X") * 3f;
        vertical = Input.GetAxis("Mouse Y");

        //if (horizontal != 0)
        //{
        //    rad -= horizontal;
        //}

        setPosition.x = player.transform.position.x + r * Mathf.Cos(Mathf.Deg2Rad * rad);

        setPosition.y = player.transform.position.y + offset.y;

        setPosition.z = player.transform.position.z + r * Mathf.Sin(Mathf.Deg2Rad * rad);

        transform.position = setPosition;

        transform.LookAt(CameraMoveObj.transform);
    }
}
