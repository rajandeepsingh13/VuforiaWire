using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyColor : MonoBehaviour {

	public Material grey;
	public Material brown;

	private Renderer rend;

//	private bool sbBrown;


	void Start () {
	
	}
	

	void Update () {
		
	}

	public void ChangeColor(bool sbBrown){
		rend = GetComponent<Renderer> ();
		if (sbBrown == true) {
			rend.material = brown;
		} else {
			rend.material = grey;
		}
	}
}
