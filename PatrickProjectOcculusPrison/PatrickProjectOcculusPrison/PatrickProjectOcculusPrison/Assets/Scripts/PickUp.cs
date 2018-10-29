using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public GameObject Door;
    private bool doorLocked = true;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
     void Update () {
        if (doorLocked == true)
        {
            var door = Door.GetComponent<Rigidbody>();
            door.constraints = RigidbodyConstraints.FreezeRotationX;
        }
        else
        {
            var door = Door.GetComponent<Rigidbody>();
            door.constraints = RigidbodyConstraints.None;
            gameObject.SetActive(false);
        }
    }
    private void OnMouseDown()
    {
        print("Key Collected, Door Unlocked");
        doorLocked = false;
    }
}
