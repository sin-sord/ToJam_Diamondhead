using UnityEngine;
using UnityEngine.InputSystem;

public class RotateScaleCentre : MonoBehaviour
{

    public SceneLoader sl;
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

        if (sl.controlsEnabled)
        {

            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("is rotating left");
                transform.Rotate(0, 0, 0.05f);
            }

            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("is rotating right");
                transform.Rotate(0, 0, -0.05f);
            }
        }

    }


}
