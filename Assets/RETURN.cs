using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RETURN : MonoBehaviour
{
    public int m = 0;
    public int Q = 0;
    // Start is called before the first frame update
    void Start()
    {
        m = 0;
        Q = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (m == 1)
            SceneManager.LoadScene("mainmenu");
        gm.type = Q;
    }
    public void change()
    {

        m = 1;
    }
    public void JOY()
    {
        Q = 0;
    }
    public void GYR()
    {
        Q = 1;
    }
}
