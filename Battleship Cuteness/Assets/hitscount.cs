using UnityEngine;
using System.Collections;

public class hitscount : MonoBehaviour {
	public int hits;

	// Use this for initialization
	void Start () {
		hits = 0;

	
	}
	void OnCollisionEnter(Collision col){
		 


		if (col.gameObject.name == "hulk" || col.gameObject.name == "mast" || col.gameObject.name == "mast1" || col.gameObject.name == "mast2") {
			Debug.Log ("Hits!!");
			hits = hits+1;
			}
		}
		

			
	// Update is called once per frame
	void Update () {

	
	}
}
