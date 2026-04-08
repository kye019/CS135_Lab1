using System.Diagnostics;
using System.Numerics;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new UnityEngine.Vector3(0,1,0));
    }
}
