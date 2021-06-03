using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawning : MonoBehaviour
{
    
    void Start()
    {
        CoinCollect.coinCount = 0;
        SceneManager.LoadScene(Global_LVL.lvlNumber);
    }

}
