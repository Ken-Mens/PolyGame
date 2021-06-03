using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public bool gamePause = false;
    public GameObject pauseMenu;
        
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePause == false)
            {
                Time.timeScale = 0;
                gamePause = true;
                Cursor.visible = true;
                this.GetComponent<AudioSource>().Pause();
                pauseMenu.SetActive(true);
            }
            else
            {
                pauseMenu.SetActive(false);
                this.GetComponent<AudioSource>().UnPause();
                Cursor.visible = false;
                gamePause = false;
                Time.timeScale = 1;

            }
        }
    }

    public void UnpauseGame()
    {
        pauseMenu.SetActive(false);
        this.GetComponent<AudioSource>().UnPause();
        Cursor.visible = false;
        gamePause = false;
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

}
