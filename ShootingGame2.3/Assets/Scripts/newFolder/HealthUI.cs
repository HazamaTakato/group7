using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthUI : MonoBehaviour
{
    public Text text;
    PlayerHit hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = GetComponent<PlayerHit>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "hp:" + hp.Hp();
        //text.transform.localScale = new Vector3(hp.hp / 100f + 1f, hp.hp / 100f + 1f);
    }
}
