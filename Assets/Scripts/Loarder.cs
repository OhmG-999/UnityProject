using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loarder : MonoBehaviour {

	public GameManager gameManager;

	// Use this for initialization
	void Awake () 
	{
		if (GameManager.instance == null)
			Instantiate (gameManager);	
	}

}
