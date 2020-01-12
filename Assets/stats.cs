using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (gameObject.name == "coinstat")
        {
            GetComponent<TextMesh>().text = "Coins : " + gm.coins;


        }
        if (gameObject.name == "timestat")
        {
            GetComponent<TextMesh>().text = "Score : " + (int)(gm.time*5+ gm.coins*3);


        }
    }
}
