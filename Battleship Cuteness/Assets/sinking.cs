using UnityEngine;
using System.Collections;

public class sinking : MonoBehaviour {
	public GameObject Bullet;
	private bool threehits = false;
	private bool fivehits = false;
	private bool eighthits = false;
	private bool tenhits = false;
	public GameObject Pirat;


	// Use this for initialization
	void Start () {
		Pirat.gameObject.SetActive (false);
	
	}

	// Update is called once per frame
	void Update () {
		Vector3 shipstate = this.gameObject.transform.position;
			if (Bullet.GetComponent<hitscount>().hits == 3 && !threehits){
				threehits = true;
				shipstate.y -= 1;
				shipstate.x -= 1;
				this.gameObject.transform.position = shipstate;
				
				
			}else if (Bullet.GetComponent<hitscount>().hits == 5 && !fivehits)
			{	
				fivehits = true;
				shipstate.y -= 1;
				shipstate.x -= 1;
				this.gameObject.transform.position = shipstate;
			}else if (Bullet.GetComponent<hitscount>().hits == 8 && !eighthits)
			{	
			eighthits = true;
			shipstate.y -= 1;
			shipstate.x -= 1;
			this.gameObject.transform.position = shipstate;
			this.gameObject.transform.Rotate(Vector3.forward*50);

		}else if (Bullet.GetComponent<hitscount>().hits == 10 && !tenhits)
		{	
			tenhits = true;
			shipstate.y -= 5;
			shipstate.x -= 5;
			this.gameObject.transform.position = shipstate;
			this.gameObject.transform.Rotate(Vector3.forward*50);
			Pirat.gameObject.SetActive(true);
			
		}

	}
}
