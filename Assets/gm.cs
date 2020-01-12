using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm : MonoBehaviour
{
    public  static float vertical_vel = 0;
    public static int coins = 0;
    public static float time = 0;
    public static float zvel = 1;
    public Transform chuchu;
    public int scenepos = 57;
    public Transform coinobj;
    public Transform obstacleobj;
    public static int type;
    public Transform capsuleobj;
    public int random;
    public int k = 0;
    public static int LEVEL=0;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       
        if (scenepos < 5700)
        {
            int p = 3-gm.LEVEL;
            int c;

            random = Random.Range(0, 10);
            if (random < p)
            {
                Instantiate(coinobj, new Vector3(0, 3.74f, scenepos), coinobj.rotation);
            }
            if (random > 7)
            {
                Instantiate(coinobj, new Vector3(-1, 3.74f, scenepos), coinobj.rotation);
            }
            if (random >p && random <7)
            {
                Instantiate(coinobj, new Vector3(1, 3.74f, scenepos), coinobj.rotation);
            }
            if(random<3)
            {
                Instantiate(obstacleobj, new Vector3(1, 3.74f, scenepos), obstacleobj.rotation);

            }
            if (random > 7)
            {
                if (k == 0)
                {
                    Instantiate(obstacleobj, new Vector3(0, 3.74f, scenepos), obstacleobj.rotation);
                    k = 1;
                }
                else if (k == 1)
                {
                    Instantiate(obstacleobj, new Vector3(-1, 3.74f, scenepos), obstacleobj.rotation);
                    k = 0;
                }
                

            }

            if (random==10)
            {
         
               Instantiate(capsuleobj, new Vector3(1, 3.74f, scenepos), capsuleobj.rotation);

             }
            if (random == 5)
            {
                Instantiate(capsuleobj, new Vector3(0, 3.74f, scenepos), capsuleobj.rotation);

            }
            if (random == 2)
            {
                Instantiate(capsuleobj, new Vector3(-1, 3.74f, scenepos), capsuleobj.rotation);

            }



            Instantiate(chuchu, new Vector3(0, 2.34f, scenepos), chuchu.rotation);
            scenepos = scenepos + 2;
        }
        time += Time.deltaTime;
        if (scenepos > 5700)
        {
            SceneManager.LoadScene("levelcomplete");
            
        }
        
    }
}
