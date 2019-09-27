using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitGame()
    {
        SceneManager.LoadScene("Quit");
    }

    public void PlayGameAgain()
    {
        SceneManager.LoadScene("Sample Scene");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
