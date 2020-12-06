using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public static class WaveChildenController 
//{

//    public static List<GameObject> GetAll(this GameObject obj)
//    {
//        List<GameObject> enemyChild = new List<GameObject>();
//        GetChildren(obj, ref enemyChild);
//        return enemyChild;
//    }


//    public static void GetChildren(GameObject obj, ref List<GameObject>EnemyChildren)
//    {
//        Transform Children = obj.GetComponentInChildren<Transform>();
//        if(Children.childCount == 0)
//        {
//            return;
//        }

//        foreach(Transform ob in Children)
//        {
//            if (ob.CompareTag("Enemy"))
//            {
//                EnemyChildren.Add(ob.gameObject);
//                GetChildren(ob.gameObject, ref EnemyChildren);
//            }
//        }
//    }
//}
