// Kevin Bopp
// Period 8
// 11/17/2016
// Menu System

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject health1;
    public GameObject health2;
    public GameObject health3;

    public Text metalText;
    

    // Takes name of level as string and loads it
    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name); // Logs name of level being loaded to console
        SceneManager.LoadScene(name);
    }

    private void OnLevelWasLoaded(int level)
    {
        if (SceneManager.GetActiveScene().name == "Level0")
        {
            if (PlayerPrefs.GetString("playerKilled") == "true")
            {
                PlayerPrefs.SetInt("lives", 3);
                PlayerPrefs.SetString("playerKilled", "false");
            }
        }

        PlayerPrefs.SetInt("levelMetal", 0);

        int lives = PlayerPrefs.GetInt("lives");
        if (PlayerPrefs.GetString("playerKilled") == "true")
        {
            PlayerPrefs.SetInt("lives", lives - 1);
            PlayerPrefs.SetString("playerKilled", "false");
        }
    }

    void Start()
    {
        int lives = PlayerPrefs.GetInt("lives");

        if (PlayerPrefs.GetInt("lives") == 3)
        {
            health1.SetActive(true);
            health2.SetActive(true);
            health3.SetActive(true);
        }
        else if (lives == 2)
        {
            health1.SetActive(true);
            health2.SetActive(true);
        }
        else if (lives == 1)
        {
            health1.SetActive(true);
        }
    }

    public void Update()
    {
        
        if (PlayerPrefs.GetInt("lives") == 2)
        {
            health3.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("lives") == 1)
        {
            health2.SetActive(false);
            health3.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("lives") == 0)
        {
            health1.SetActive(false);
            health2.SetActive(false);
            health3.SetActive(false);
        }

        if (((PlayerPrefs.GetInt("levelMetal") + PlayerPrefs.GetInt("totalMetal")) >= 50) && (PlayerPrefs.GetInt("lives") < 3))
        {
            int totalMetal = (PlayerPrefs.GetInt("levelMetal") + PlayerPrefs.GetInt("totalMetal")) - 50;
            int newLives = PlayerPrefs.GetInt("lives") + 1;
            PlayerPrefs.SetInt("levelMetal", 0);
            PlayerPrefs.SetInt("totalMetal", totalMetal);
            PlayerPrefs.SetInt("lives", newLives);

            if (newLives == 3)
            {
                health1.SetActive(true);
                health2.SetActive(true);
                health3.SetActive(true);
            }
            else if (newLives == 2)
            {
                health1.SetActive(true);
                health2.SetActive(true);
            }
            else if (newLives == 1)
                health1.SetActive(true);
            }

        metalText.text = "Metal: " + (PlayerPrefs.GetInt("totalMetal") + PlayerPrefs.GetInt("levelMetal"));
    }
}