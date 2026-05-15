using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBUtton : MonoBehaviour
{
    public GameObject creditsButton;
    public GameObject controlsButton;
   
    public void PlayGame()
    {
        SceneManager.LoadScene("Decision 1");
    }

    public void Credits()
    {
        creditsButton.SetActive(true); 
    }

    public void DisableCredits()
        { creditsButton.SetActive(false); }

    public void Controls()
        { controlsButton.SetActive(true); }

    public void DisableControls()
    {
        controlsButton.SetActive(false);
    }


}
