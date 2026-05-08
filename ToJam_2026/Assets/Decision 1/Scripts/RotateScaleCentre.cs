using UnityEngine;
using UnityEngine.InputSystem;

public class RotateScaleCentre : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateScaleLR();
    }

    void rotateScaleLR()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            Debug.Log("is rotating left");
            transform.Rotate(0,0,0.02f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("is rotating right");
            transform.Rotate(0, 0, -0.02f);
        }

    }


}
