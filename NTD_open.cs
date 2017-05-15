using UnityEngine;
using System.Collections;

public class NTD_open : MonoBehaviour 
{

	public GameObject NTDobject;

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

			NTDobject.GetComponent<Animator> ().enabled = true;

		}

	}

}
