using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
	public float speed = 5.0f;
	public int raycastDist = 100;
	public GameObject Bullet ;
	public GameObject SeaCol;
	public GameObject Aca;

	public float thrust;

	void Start(){
		
	}
	void Update ()
	{

		Vector3 forward = transform.TransformDirection(Vector3.forward) *100;
		Vector3 upperray = transform.TransformDirection(0,1,50) *100;
		Vector3 lowerray = transform.TransformDirection(0,-1,50) *100;
		Vector3 leftray = transform.TransformDirection(-1,0,50) *100;
		Vector3 rightray = transform.TransformDirection(1,0,50) *100;
		Debug.DrawRay(transform.position, forward, Color.green);
		Debug.DrawRay(transform.position, upperray, Color.black);
		Debug.DrawRay(transform.position, lowerray, Color.yellow);
		Debug.DrawRay(transform.position, leftray, Color.blue);
		Debug.DrawRay(transform.position, rightray, Color.red);


		if (Aca.gameObject.GetComponent<PlayerSkript>().labo && Physics.Raycast (transform.position, forward, 100)) {
			Debug.Log ("asd");
			if (Input.GetKey (KeyCode.W) && Physics.Raycast (transform.position, upperray, 100)) {
				transform.Rotate (Vector3.left * speed * Time.deltaTime);

			}
			if (Input.GetKey (KeyCode.S) && Physics.Raycast (transform.position, lowerray, 100)) {
				transform.Rotate (Vector3.right * speed * Time.deltaTime);

			}
			if (Input.GetKey (KeyCode.D) && Physics.Raycast (transform.position, rightray, 100)) {
				transform.Rotate (Vector3.up * speed * Time.deltaTime);

			}
			if (Input.GetKey (KeyCode.A) && Physics.Raycast (transform.position, leftray, 100)) {
				transform.Rotate (Vector3.down * speed * Time.deltaTime);
			}
		}

		if (Input.GetKeyDown (KeyCode.Space)) {

			Bullet.gameObject.SetActive (true);
			Debug.Log("False inc");
			SeaCol.gameObject.SetActive (false);
			Bullet.gameObject.GetComponent<Rigidbody> ().AddForce (transform.forward * thrust);


		}
	}
}