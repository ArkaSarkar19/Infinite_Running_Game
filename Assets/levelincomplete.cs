using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelincomplete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gm.coins = 0;
            gm.zvel = 1;
            gm.time = 0;
            SceneManager.LoadScene("mainmenu");
        }
    }
}
