using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public int rotating = 1;

    void Update()
    {
        transform.Rotate(0, rotating * Time.timeScale, 0, Space.World);
    }
}