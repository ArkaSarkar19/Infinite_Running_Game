using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenugm : MonoBehaviour
{ int scen;
    // Start is called before the first frame update
    void Start()
    {
        scen = 0;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        else if ((scen == 1))
        {if (gm.type == 1)
                SceneManager.LoadScene("level1a");
            else
                SceneManager.LoadScene("level1b");
        }
        else if (scen == 2)
            SceneManager.LoadScene("op1");
        else if (scen == 3)
        { SceneManager.LoadScene("how"); }
        else if (scen == 4)
        {
            SceneManager.LoadScene("difficult");
        }    }
    public void options()
    { scen = 2; }
    public void start() { scen = 1;
    }
  
    public void how() {
        scen = 3;
            }
    public void level() { scen = 4; }
}

