using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public float speed = 200.0f;

	// Use this for initialization
	void Start () {
        
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("jhjjfgjgf");
        if (col.gameObject.name == "Ground")
        {
            // object collided with something called "Ground":
            // do whatever you want: set a new direction, set a boolean variable, etc.
        }
    }
	
	// Update is called once per frame
	void Update () {

    if(Input.GetKey(KeyCode.A))
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.left * speed * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.D))
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.right * speed * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.W))
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * speed * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.S))
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.down * speed * Time.deltaTime);
    }

    }
}
