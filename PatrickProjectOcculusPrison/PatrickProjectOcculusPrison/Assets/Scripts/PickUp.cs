using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PickUp : MonoBehaviour {
    public GameObject DoorLock;
    private bool doorLocked = true;

	// Use this for initialization
	void Start ()
	{
	}

    // Update is called once per frame
     void Update () {
        if (doorLocked == false)
        {
            DoorLock.SetActive(false);

        }

         if (doorLocked ==
             false && gameObject.GetComponent<AudioSource>().isPlaying == false)
         {
             gameObject.SetActive(false);

         }
    }
    private void OnMouseDown()
    {
        print("Key Collected, Door Unlocked");
        transform.position = new Vector3(transform.position.x, 100, transform.position.z);
        gameObject.GetComponent<AudioSource>().Play();
        doorLocked = false;
    }
}
