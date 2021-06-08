using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVL_complete : MonoBehaviour
{
    public int importedCoins;
    public GameObject completedText;
    public GameObject fadeOut;
    public GameObject player;

    void Update()
    {
        importedCoins = CoinCollect.coinCount;
        if (importedCoins == 5)
        {

            StartCoroutine(LevelCompleted());
        }
    }
    IEnumerator LevelCompleted()
    {
        yield return new WaitForSeconds(0.3f);
        completedText.SetActive(true);
        fadeOut.SetActive(true);
        player.GetComponent<PlayerControl>().enabled = false;
        yield return new WaitForSeconds(3);
        Global_LVL.lvlNumber += 1;
        SceneManager.LoadScene(Global_LVL.lvlNumber);
    }
      
}
