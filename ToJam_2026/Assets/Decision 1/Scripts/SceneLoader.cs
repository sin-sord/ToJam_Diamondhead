using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public SpriteRenderer completionScreenAIcon;
    public SpriteRenderer completionScreenBIcon;

    //public MeshRenderer completionTextA;
    //public MeshRenderer completionTextB;

    public SpriteRenderer PressSpace;
    [SerializeField]
    public bool controlsEnabled;


    public SpriteRenderer outcomeA;
    public SpriteRenderer outcomeB;


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
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(Random.Range(2,12));
            
            controlsEnabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        controlsEnabled =false;

        if (other.tag == "ScaleBaseA")
        {
            completionScreenAIcon.enabled = true;
            //completionTextA.enabled = true;
            PressSpace.enabled = true;
            outcomeA.enabled = true;

            Debug.Log("Scale Option A was Selected");

        }

        if (other.tag == "ScaleBaseB")
        {
            completionScreenBIcon.enabled = true;
            //completionTextB.enabled = true;
            PressSpace.enabled = true;
            outcomeB.enabled = true;


            Debug.Log("Scale Option B was Selected");
                
        }
    }

}
