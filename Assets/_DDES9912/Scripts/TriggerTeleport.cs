using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform destination;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = destination.position;
    }
}
