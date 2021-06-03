using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Global_Time : MonoBehaviour
{

    public GameObject timeDisplay;
    public int seconds = 30;
    public bool deductingTime;
    public GameObject timeupText;
    public GameObject fadeOut;
    public GameObject player;

    // void Start()
    // {
    //      StartCoroutine(DeducSecond());
    //  }

    // Update is called once per frame
    void Update()
    {
        if (seconds == 0)
        {
            player.GetComponent<PlayerControl>().enabled = false;
            seconds = 0;
            timeupText.SetActive(true);
            fadeOut.SetActive(true);
            StartCoroutine(RespawningLevel());
            
        }
        else
        {

            if (deductingTime == false)
            {
                deductingTime = true;
                StartCoroutine(DeducSecond());
            }
        }
    }

    IEnumerator DeducSecond()
    {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "TIME: " + seconds;
        deductingTime = false;
    }

    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
