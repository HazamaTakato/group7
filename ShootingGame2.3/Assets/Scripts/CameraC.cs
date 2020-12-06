using UnityEngine;

public class CameraC : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private Vector3 setPosition;

    private float moveOffsetY;
    //半径
    private float r = 5;
    //ラジアン
    private float rad = 0;

    //横移動量
    float horizontal;
    //縦移動量
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position + player.transform.position;
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

        if (vertical != 0)
        {
            moveOffsetY -= vertical;
        }

        setPosition.x = player.transform.position.x - r * Mathf.Cos
            (Mathf.Deg2Rad * rad);

        setPosition.y = player.transform.position.y - moveOffsetY;

        setPosition.z = player.transform.position.z - r * Mathf.Sin
            (Mathf.Deg2Rad * rad);

        transform.position = setPosition;
    }
}
