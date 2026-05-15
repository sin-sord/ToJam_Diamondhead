using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public SpriteRenderer completionScreenAIcon;
    public SpriteRenderer completionScreenBIcon;

    public GameObject textBoard_ResultA;
    public GameObject textBoard_ResultB;
    public GameObject textBoard_Choose;
    public GameObject lights;
    public GameObject textBoard_Model;



    //public MeshRenderer completionTextA;
    //public MeshRenderer completionTextB;

    public SpriteRenderer PressSpace;
    [SerializeField]
    public bool controlsEnabled;


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

        textBoard_Choose.SetActive(false);
        textBoard_Model.SetActive(true);
        lights.SetActive(true);

        if (other.tag == "ScaleBaseA")
        {
            completionScreenAIcon.enabled = true;   
            //completionTextA.enabled = true;
            PressSpace.enabled = true;
            textBoard_ResultA.SetActive(true);

            Debug.Log("Scale Option A was Selected");

        }

        if (other.tag == "ScaleBaseB")
        {
            completionScreenBIcon.enabled = true;
            //completionTextB.enabled = true;
            PressSpace.enabled = true;
            textBoard_ResultB.SetActive(true);

            Debug.Log("Scale Option B was Selected");
                
        }
    }

}
