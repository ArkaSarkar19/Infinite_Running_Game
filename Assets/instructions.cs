using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class instructions : MonoBehaviour
{
    public int m;
    // Start is called before the first frame update
    void Start()
    {
        m = -1;
    }

    // Update is called once per frame
    void Update()
    {if (m == 0)
            SceneManager.LoadScene("ons");
        else if (m == 1)
            SceneManager.LoadScene("gyr");
        else if (m == 2)
            SceneManager.LoadScene("mainmenu");

        
    }
    public void gyr()
    { m = 1; }
    public void ons()
    { m = 0; }
    public void ret() { m = 2; }
}
