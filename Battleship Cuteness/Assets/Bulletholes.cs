using UnityEngine;
using System.Collections;

public class Bulletholes : MonoBehaviour {
	public GameObject Bullet;
	public Transform Hole;
	public GameObject SeaCol;
	public Vector3 bulletposition;
	void OnCollisionEnter(Collision collision){
		Debug.Log ("Do stuff");
		ContactPoint contact = collision.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, Vector3.up);
		Vector3 pos = contact.point;
		Instantiate(Hole, pos, rot);


	}
}