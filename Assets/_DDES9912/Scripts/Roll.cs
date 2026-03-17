using UnityEngine;

public class Roll : MonoBehaviour
{
    public Rigidbody subject;
    public float spinforce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I AM HIT");
        subject.AddTorque(0, 0, spinforce);
    }
}
