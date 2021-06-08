using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 8f;
    public GameObject Sharky;


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            Sharky.transform.localRotation = Quaternion.Euler(0, 270, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            Sharky.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed * -1);
            Sharky.transform.localRotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * -1);
            Sharky.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            Sharky.transform.localRotation = Quaternion.Euler(0, 45, 0);
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            Sharky.transform.localRotation = Quaternion.Euler(0,135, 0);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            Sharky.transform.localRotation = Quaternion.Euler(0, 225, 0);
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            Sharky.transform.localRotation = Quaternion.Euler(0, 315, 0);
        }
    }
}
