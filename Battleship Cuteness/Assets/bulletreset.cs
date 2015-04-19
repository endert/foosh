using UnityEngine;
using System.Collections;

public class bulletreset : MonoBehaviour {
	public Vector3 bulletposition;
	public GameObject Bullet;
	public GameObject SeaCol;
	public float thrust;
	public GameObject Aca;
	public float myTimer = 2.0f;
	bool isRunning = true;

	// Use this for initialization
	void Start(){
		bulletposition = Bullet.gameObject.transform.position;
	}
	/*void OnTriggerEnter2D(Collider2D col){
		Debug.Log("Treffer");
		if (col.gameObject.name == "Ship") {

		}
	}*/
	void OnCollisionEnter(Collision col){
		Debug.Log ("Collisions");
		if (col.gameObject.name == "hulk" || col.gameObject.name == "mast" || col.gameObject.name == "mast1" || col.gameObject.name == "mast2") {
			Bullet.gameObject.transform.position = bulletposition;
			Bullet.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);	Bullet.gameObject.SetActive (false);
			SeaCol.gameObject.SetActive(true);
		}
			

		
	}
	void OnTriggerEnter(Collider col){
		
		if (col.gameObject.name == "Sceneplate" || col.gameObject.name == "LowerSceneplate" ) {
			Bullet.gameObject.transform.position = bulletposition;
			Bullet.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
			Bullet.gameObject.SetActive (false);
			SeaCol.gameObject.SetActive(true);
		}
		
		
		
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
