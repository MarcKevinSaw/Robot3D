using UnityEngine;
using System.Collections;

public class light_open : MonoBehaviour 
{
	public GameObject lightobject;

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider player)
	{

		if (player.CompareTag ("Player")) 
		{

			lightobject.SetActive (true);

		}

	}
}
