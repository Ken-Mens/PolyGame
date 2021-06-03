using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_LVL : MonoBehaviour
{
    public static int lvlNumber = 1;
    public int internalNUM;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalNUM = lvlNumber;
    }
}
