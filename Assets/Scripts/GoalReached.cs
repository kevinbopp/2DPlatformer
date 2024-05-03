using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoalReached : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D col)
    {
        int totalMetal = PlayerPrefs.GetInt("totalMetal");

        // add levelMetal collected to total metal
        PlayerPrefs.SetInt("totalMetal", PlayerPrefs.GetInt("levelMetal") + totalMetal);
        PlayerPrefs.SetInt("levelMetal", 0);

        // Load the next level here
        int thisScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(thisScene + 1);
    }
}
