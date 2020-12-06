using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseObjectPosition : MonoBehaviour
{   // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;

    Vector3 ObPosition;

    public Transform playerTrans;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3でマウス位置座標を取得する
        transform.position = new Vector3(playerTrans.position.x,playerTrans.position.y + 1,5);
        // Z軸修正
        //position.z = 25f;
        //// マウス位置座標をスクリーン座標からワールド座標に変換する
        //screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
        //// ワールド座標に変換されたマウス座標を代入
        //gameObject.transform.position = screenToWorldPointPosition;

        //ObPosition = transform.position;
    }

    public Vector3 MousePosition()
    {
        return ObPosition;
    }
}
