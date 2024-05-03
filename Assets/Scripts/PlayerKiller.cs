using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class PlayerKiller : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            PlayerPrefs.SetString("playerKilled", "true");
            int lives = PlayerPrefs.GetInt("lives");

            if (other.tag == "Player")
            {
                if (lives - 1 == -1)
                {
                    SceneManager.LoadScene("Lose");
                }
                else
                {
                    SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
                }
            }
        }
    }
}
