using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIFFICULT : MonoBehaviour
{
 public    int le = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gm.LEVEL = le;
    }
    public void easy()
    {
        le=0;
    }
    public void medium()

    {
        le = 1;
    }
    public void hard()
    { le = 2; }
}
