using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayLVL()
    {
        SceneManager.LoadScene(7);
    }
    public void PlayMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayNextLVL()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
