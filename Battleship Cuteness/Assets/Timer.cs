using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float myTimer = 90.0f;
    bool isRunning = true;
    public string timerText;

	// Use this for initialization
	void Start () {
        
	}

    void OnGUI()
    {
        GUI.Label(new Rect(680, 10, 100, 20), timerText + " sec");
    }
	
	// Update is called once per frame
	void Update () {

        timerText = myTimer.ToString();

        if (myTimer > 0)
            myTimer -= Time.deltaTime;
        else if(isRunning)
        {
            Debug.Log("GAME OVER");
            isRunning = false;
        }

        //stringToEdit = GUI.TextField(new Rect(-5, 10, 20, 20), stringToEdit, 25);
        


    }
}
