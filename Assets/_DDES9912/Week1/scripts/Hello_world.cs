using System.Diagnostics;
using UnityEngine;

public class Hello_world : MonoBehaviour
{
    public int a;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log(a);

        a++;

    }
}
