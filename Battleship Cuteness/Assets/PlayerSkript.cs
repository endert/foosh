using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSkript : MonoBehaviour {

    public float speed = 200.0f;
    public Stack<GameObject> foodStack = new Stack<GameObject>();

    private bool isPressed = false;
    private int counter = 1;
 
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Ham(Clone)")
            col.name = "Ham";

        if (col.gameObject.name == "Ham")
        {
            Debug.Log("lkdjsajlfk");
            foodStack.Push(col.gameObject);
            //Destroy(col.gameObject);
            col.gameObject.SetActive(false);
            Debug.Log(foodStack.Peek());
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space) && !isPressed)
        {
            //var gameObj : GameObject = GameObject.CreatePrimitive(foodStack.Pop());
            //gameObj.transform.position = Vector3(0, 0.5, 0);

            foodStack.Peek().gameObject.SetActive(true);
            Instantiate(foodStack.Peek(), new Vector3(counter++ * 2.0f, 0f, 0f), Quaternion.identity);

           

            foodStack.Pop().gameObject.SetActive(false);            
            isPressed = true;
        }

        if (!Input.GetKey(KeyCode.Space))
            isPressed = false;

     

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
