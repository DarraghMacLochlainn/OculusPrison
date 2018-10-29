using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour {
	public GameObject DoorLock;
	private bool doorLocked = true;
	
	void Start () {
	}

	 void Update()
	{
		if (doorLocked==false)
		{
			DoorLock.SetActive(false);

		}
	}

	private void OnMouseDown()
	{
		doorLocked = false;		
		gameObject.GetComponent<AudioSource>().Play();
        print("Button Pressed, Door Unlocked");
	}
}
