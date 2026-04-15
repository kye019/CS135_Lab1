using UnityEngine;

public class BallDropScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.useGravity=true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
