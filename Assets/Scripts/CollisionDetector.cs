using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

	public GameObject Maze;
	public GameObject Monkey;

	[HideInInspector]
	public bool shouldBeBrown = false;

	void Start () {

	}

	void Update () {
		
	}

	private void OnTriggerEnter(Collider target)
	{
		if (target.tag == Tags.MazeWire_Tag) {
			Maze.SetActive (false);
			shouldBeBrown = true;
			Monkey.GetComponent<MonkeyColor> ().ChangeColor (shouldBeBrown);
		}
		if (target.tag == Tags.Monkey_Tag) {
			Maze.SetActive (true);
			shouldBeBrown = false;
			Monkey.GetComponent<MonkeyColor> ().ChangeColor (shouldBeBrown);
		}

	}
}
