using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalCollector : MonoBehaviour {

    public GameObject metal;

    int moveTick = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (metal.tag == "Screw")
        {
            PlayerPrefs.SetInt("levelMetal", PlayerPrefs.GetInt("levelMetal") + 1);
        }
        else if (metal.tag == "Screwdriver")
        {
            PlayerPrefs.SetInt("levelMetal", PlayerPrefs.GetInt("levelMetal") + 3);
        }
        else if (metal.tag == "Wrench")
        {
            PlayerPrefs.SetInt("levelMetal", PlayerPrefs.GetInt("levelMetal") + 5);
        }
        else if (metal.tag == "Gear1")
        {
            PlayerPrefs.SetInt("levelMetal", PlayerPrefs.GetInt("levelMetal") + 10);
        }
        else if (metal.tag == "Gear2")
        {
            PlayerPrefs.SetInt("levelMetal", PlayerPrefs.GetInt("levelMetal") + 15);
        }
        Destroy(metal);
        Debug.Log("levelMetal: " + PlayerPrefs.GetInt("levelMetal"));
    }

    private void Update()
    {
        if (moveTick < 100)
        {
            transform.Translate(new Vector3(0, 0.005f, 0));
            moveTick++;
        }
        else if (moveTick >= 100 && moveTick < 200)
        {
            transform.Translate(new Vector3(-0, -0.005f, 0));
            moveTick++;
        }
        else
        {
            moveTick = 0;
        }
    }
}