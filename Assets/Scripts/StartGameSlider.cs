using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameSlider : MonoBehaviour {

    int moveTick = 0;
    public GameObject arrow;
	
	// Update is called once per frame
	void Update () {
        if (moveTick < 100)
        {
            arrow.transform.Translate(new Vector3(0.015f, 0, 0));
            moveTick++;
            moveTick++;
            moveTick++;
        }
        else if (moveTick >= 100 && moveTick < 200)
        {
            arrow.transform.Translate(new Vector3(-0.015f, 0, 0));
            moveTick++;
            moveTick++;
            moveTick++;
        }
        else
        {
            moveTick = 0;
        }
        transform.Rotate(5, 0, 0);
    }
}
