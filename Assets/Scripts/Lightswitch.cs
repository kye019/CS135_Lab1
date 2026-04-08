using System.Drawing;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    private Light light;
    int x = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            if (x == 0)
            {
                light.color = new UnityEngine.Color(255, 255, 255);
                x=1;
            }
            else
            {
                light.color = new UnityEngine.Color(0,0,0);
                x=0;
            }

        } 
    }
}
