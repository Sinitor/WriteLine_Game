using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool Menu;
    public GameObject GameMenu;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chess")
        {
            UnLockLevel();
            GameMenu.SetActive(true);
            Menu = true;
        }

        if (collision.gameObject.tag == "Skull")
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Skull")
        {
            SceneManager.LoadScene(0);
        }
    }
    public void UnLockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levels4"))
        {
            PlayerPrefs.SetInt("levels4", currentLevel + 1);
        }
    }
}
