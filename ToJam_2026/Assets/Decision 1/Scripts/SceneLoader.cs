using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public SpriteRenderer completionScreenA;
    public SpriteRenderer completionScreenB;
    [SerializeField]
    public bool controlsEnabled;

    GameObject completionScreenObjectA;
    GameObject completionScreenObjectB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controlsEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !controlsEnabled)
        {
            Debug.Log("Transition to the next scene");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        controlsEnabled =false;

        if (other.tag == "ScaleBaseA")
        {
            completionScreenA.enabled = true;

            Debug.Log("Scale Option A was Selected");

        }

        if (other.tag == "ScaleBaseB")
        {
            completionScreenB.enabled = true;
            Debug.Log("Scale Option B was Selected");
                
        }
    }

}
