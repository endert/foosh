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

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            // object collided with something called "Ground":
            // do whatever you want: set a new direction, set a boolean variable, etc.
        }

    }

    void OnTriggerEnter(Collider col)
    {
    //    if (col.name == "ham(Clone)")
    //        col.name = "ham";

    //    if (col.name == "cake(Clone)")
    //        col.name = "cake";

    //    if (col.name == "poo(Clone)")
    //        col.name = "poo";

    //    if (col.name == "stone(Clone)")
    //        col.name = "stone";

    //    if (col.name == "fish(Clone)")
    //        col.name = "fish";


        if ((col.gameObject.tag == "ham" || col.gameObject.tag == "cake" || col.gameObject.tag == "fish"
            || col.gameObject.tag == "poo" || col.gameObject.tag == "stone") && foodStack.Count < 10)
        {
            foodStack.Push(col.gameObject);
            col.gameObject.transform.position = new Vector3(-122 + 5 * (foodStack.Count - 1), -100, 1);
            col.gameObject.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
            col.gameObject.transform.localScale = new Vector3(1, 1, 1);
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
        //GetComponent<Rigidbody>().AddForce(Vector3.left * speed * Time.deltaTime);

        Vector3 position = this.transform.position;
        position.x--;
        this.transform.position = position;
    }

    if (Input.GetKey(KeyCode.D))
    {
        //GetComponent<Rigidbody>().AddForce(Vector3.right * speed * Time.deltaTime);

        Vector3 position = this.transform.position;
        position.x++;
        this.transform.position = position;
    }

    if (Input.GetKey(KeyCode.W))
    {
        //GetComponent<Rigidbody>().AddForce(Vector3.up * speed * Time.deltaTime);

        Vector3 position = this.transform.position;
        position.z++;
        this.transform.position = position;
    }

    if (Input.GetKey(KeyCode.S))
    {
        //GetComponent<Rigidbody>().AddForce(Vector3.down * speed * Time.deltaTime);

        Vector3 position = this.transform.position;
        position.z--;
        this.transform.position = position;
    }

    }
}
