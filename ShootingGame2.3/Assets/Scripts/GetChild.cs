using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChild : MonoBehaviour
{
    //public List<GameObject> list;
    //GameObject playerPos;
    //PlayerController pos;
    //int x;
    //int count;
    //int rand;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    list = WaveChildenController.GetAll(gameObject);
    //    playerPos = GameObject.Find("Player");
    //    pos = playerPos.GetComponent<PlayerController>();

    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //    //for (int i = 0; i < list.Count; i++)
    //    //{
    //    //    if(i >= list.Count - 1)
    //    //    {
    //    //        x = 0;
    //    //    }
    //    //    else
    //    //    {
    //    //        x = i + 1;
    //    //    }
    //    //    float area = (list[i].transform.position.z - pos.Pos().z)
    //    //                *(list[i].transform.position.x - pos.Pos().x)
    //    //                *0.5f;
    //    //    float area2 = (list[x].transform.position.z - pos.Pos().z)
    //    //                * (list[x].transform.position.x - pos.Pos().x)
    //    //                * 0.5f;
    //    //    if (area > area2)
    //    //    {
    //    //        list.Insert(0, list[i + 1]);
    //    //    }
    //    //    else return;
    //    //}

    //    for(int i = 0;i < list.Count; i++)
    //    {
    //        if (list[i] != null)
    //            return;
    //        else
    //        {
    //            list.Remove(list[i]);
    //        }
    //    }

    //    count = list.Count;
    //    rand = Random.Range(0, count - 1);
    //}

    //public Vector3 EnemyPos()
    //{
    //    Vector3 ePos;
    //    if(list == null)
    //    {
    //        ePos = Vector3.zero;
    //        return ePos;
    //    }
    //    else if(list.Count == 1)
    //    {
    //        ePos = list[0].transform.position;
    //    }
    //    else 
    //    {
    //        ePos = list[rand].transform.position;
    //    }
    //    return ePos;
    //}
}
