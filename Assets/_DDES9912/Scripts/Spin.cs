using UnityEngine;

public class Spin : MonoBehaviour
{
    public float Yspeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Yspeed * Time.deltaTime, 0);
    }
}
