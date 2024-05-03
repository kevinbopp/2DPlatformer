using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGameSetup : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("levelMetal", 0);
        PlayerPrefs.SetInt("totalMetal", 0);
        Debug.Log("Metal: " + PlayerPrefs.GetInt("metal"));
        PlayerPrefs.SetInt("lives", 3);
        Debug.Log("Health: " + PlayerPrefs.GetInt("lives"));
    }
}
