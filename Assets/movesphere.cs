using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;

public class movesphere : MonoBehaviour
{
    public int moveL;
    public int moveR;
    public float horizontal_velocity=0;
    public int laneNum = 2;
    public string controllock = "n";
    public Transform aftermautobj;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI CoinsText;
  
    // Start is called before the first frame update
    void Start()
    {

        SetCoinsText();
        SetScoreText();
         moveL = moveR = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Scene m_Scene = SceneManager.GetActiveScene();
        string sceneName = m_Scene.name;
        if (sceneName == "level1b")
        {


            GetComponent<Rigidbody>().velocity = new Vector3(horizontal_velocity, gm.vertical_vel, 4);

            //  if (y>70 && y<100 && (laneNum > 1) && (controllock=="n"))
            if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("mainmenu");
        }
      
        
            if ((moveL == 1) && (laneNum > 1) && (controllock == "n"))



            {
                horizontal_velocity = -2;
                StartCoroutine(stopSlide());
                laneNum -= 1;
                controllock = "y";
                moveL = 0;

            }
            if ((moveR == 1) && (laneNum < 3) && (controllock == "n"))

            //     if ((y>260 && y<360)||(y<30 && y>0) && (laneNum<3) && (controllock == "n"))
            {
                horizontal_velocity = +2;
                StartCoroutine(stopSlide());
                laneNum += 1;
                controllock = "y";
                moveR = 0;
            }
        }
        if(sceneName == "level1a")
        {
            Vector3 tilt = Input.acceleration;
            tilt = Quaternion.Euler(90, 0, 0) * tilt;
            horizontal_velocity = tilt.x;
            GetComponent<Rigidbody>().velocity = new Vector3(horizontal_velocity*6, gm.vertical_vel, 4);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("mainmenu");
            }
        }


    }
    public void left()
    {
        moveL = 1;
    }
    public void right()
    {
        moveR = 1;
    }
    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizontal_velocity = 0;
        controllock = "n";

    }
     void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "maut")
        {
            Destroy(gameObject);
           gm.zvel = 0;

           Instantiate(aftermautobj, transform.position, aftermautobj.rotation);
            
            SceneManager.LoadScene("levelincomplete");
        }
        if(other.gameObject.name == "Capsule")
        {
            Destroy(other.gameObject);
        }
       
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "rampbt")
        {
            gm.vertical_vel = 2;
        }
        if(other.gameObject.name == "ramptop")
        {
            gm.vertical_vel = 0;
        }
        if(other.gameObject.name == "exit")
        {
            SceneManager.LoadScene("levelcomplete");
        }
        if (other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
            gm.coins += 1;
            SetCoinsText();
            SetScoreText();

        }
        if (other.gameObject.tag == "capsule")
        {
            Destroy(other.gameObject);
            gm.coins += 5;
            SetCoinsText();
            SetScoreText();
        }
    }
    void SetScoreText()
    {
        ScoreText.text = "Score : " + ((int)gm.time * 5 + (int)gm.coins * 3).ToString();
    }
    void SetCoinsText()
    {
        CoinsText.text = "Coins : " + gm.coins.ToString();
    }
    
        


    

}

