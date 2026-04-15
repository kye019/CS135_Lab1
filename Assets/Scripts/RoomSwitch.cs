using System.Numerics;
using System.Security.Cryptography;
using UnityEngine;

public class RoomSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new UnityEngine.Vector3(60, 1, 0);
            GetComponent<CharacterController>().enabled = true;
        }
        if (Input.GetKeyDown("1"))
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new UnityEngine.Vector3(0, 1, 0);
            GetComponent<CharacterController>().enabled = true;
        }
        if (Input.GetKeyDown("3"))
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = new UnityEngine.Vector3(-75, 1, 0);
            GetComponent<CharacterController>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
