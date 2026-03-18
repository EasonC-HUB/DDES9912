using UnityEngine;

public class SpinHandle : MonoBehaviour
{
    public float speed = 200f;
    public float targetAngle = 45f;

    private float rotated = 0f;
    private bool pulling = false;
    private bool returning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (pulling)
        {
            transform.Rotate(0, step, 0);
            rotated += step;

            if (rotated >= targetAngle)
            {
                pulling = false;
                returning = true;
            }
        }
        else if (returning)
        {
            transform.Rotate(0, -step, 0);
            rotated -= step;

            if (rotated <= 0)
            {
                returning = false;
            }
        }
    }

    public void PullHandle()
    {
        rotated = 0f;
        pulling = true;
        returning = false;
    }
}
