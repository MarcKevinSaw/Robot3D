using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour 
{

	public GameObject Flash;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetMouseButtonDown (0))
		{

			if (Flash.GetComponent<Light> ().enabled == true) {

				Flash.GetComponent<Light> ().enabled = false;

			} 
			else 
			{

				Flash.GetComponent<Light> ().enabled = true;

			}

		}

	}
}
