using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour {
	public GameObject Door;
	private bool doorLocked = true;
	
	void Start () {
	}

	 void Update()
	{
		if (doorLocked==true)
		{
			var door = Door.GetComponent<Rigidbody>();
			door.constraints = RigidbodyConstraints.FreezeRotationX;		
		}
		else
		{
			var door = Door.GetComponent<Rigidbody>();
			door.constraints = RigidbodyConstraints.None;
		}
	}

	private void OnMouseDown()
	{
		doorLocked = false;
        print("Button Pressed, Door Unlocked");
	}
}
