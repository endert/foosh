using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float myTimer = 90.0f;
    bool isRunning = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (myTimer > 0)
            myTimer -= Time.deltaTime;
        else if(isRunning)
        {
            Debug.Log("GAME OVER");
            isRunning = false;
        }
    }
}
