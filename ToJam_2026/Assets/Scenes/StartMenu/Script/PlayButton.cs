using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayBUtton : MonoBehaviour
{
    public GameObject creditsButton;
   
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
}
