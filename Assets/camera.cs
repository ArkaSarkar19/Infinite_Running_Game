﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Rigidbody cam;
    public bool isflat = true;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody>().velocity = new Vector3(0, gm.vertical_vel,4);
        

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, gm.vertical_vel, 4*gm.zvel);
      
   }
}
