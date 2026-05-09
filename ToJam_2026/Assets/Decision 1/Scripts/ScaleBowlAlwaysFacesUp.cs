using UnityEngine;
using UnityEngine.Animations;

public class ScaleBowlAlwaysFacesUp : MonoBehaviour
{
    public Rigidbody rb;
    public Transform nail;
    public float rotationSpeed = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb = GetComponent<Rigidbody>();
        //rb = LookAtConstraint 

        //Vector3 pointToLookAt = nail.position;
        //Quaternion pointRotation = Quaternion.LookRotation(Vector3.forward, nail.position.normalized);
        //rb.MoveRotation(pointRotation);

        //Vector3 direction = (nail.position - rb.position).normalized;
        //Quaternion targetRotation = Quaternion.LookRotation(direction);
        //Quaternion nextRotation = Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed*Time.fixedDeltaTime);
        //rb.MoveRotation(nextRotation);
     
    }
}
