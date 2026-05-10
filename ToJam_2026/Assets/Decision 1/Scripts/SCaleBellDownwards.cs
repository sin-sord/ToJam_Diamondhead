using UnityEngine;

public class SCaleBellDownwards : MonoBehaviour
{
    public float velocity;
    public float acceleration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity += acceleration * (transform.eulerAngles.z - 180);
        velocity *= 0.95f;
        transform.eulerAngles -= (velocity / 20) * Vector3.forward;
    }
}
