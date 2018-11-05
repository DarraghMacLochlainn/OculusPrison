using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnviromentalDanger : MonoBehaviour
{
	public float x;
	public float z;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			other.transform.position = new Vector3(x, transform.position.y, z);
		}
	}
}
