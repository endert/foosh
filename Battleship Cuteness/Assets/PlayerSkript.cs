using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSkript : MonoBehaviour {

    public float speed = 200.0f;
    public Stack<GameObject> foodStack = new Stack<GameObject>();

    private bool isPressed = false;
    private int counter = 1;
    private int counterPos = 0;
 
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
        if (col.name == "ham(Clone)")
            col.name = "ham";

        if (col.name == "cake(Clone)")
            col.name = "cake";

        if (col.name == "poo(Clone)")
            col.name = "poo";

        if (col.name == "stone(Clone)")
            col.name = "stone";

        if (col.name == "fish(Clone)")
            col.name = "fish";


        if (col.gameObject.name == "ham" || col.gameObject.name == "cake" || col.gameObject.name == "fish" || col.gameObject.name == "poo" || col.gameObject.name == "stone")
        {
            foodStack.Push(col.gameObject);
            col.gameObject.transform.position = new Vector3(-122 + 5 * (foodStack.Count - 1), -100, 1);
            //col.gameObject.transform.localScale = new Vector3(2, 2, 1);
            //col.gameObject.SetActive(false);
            Debug.Log(foodStack.Peek());
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space) && !isPressed)
        {
            foodStack.Peek().gameObject.SetActive(true);
            Instantiate(foodStack.Peek(), new Vector3(counter++ * 2.0f, 0f, 0f), Quaternion.identity);
            foodStack.Peek().gameObject.transform.localScale = new Vector3(1, 1, 1);
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
