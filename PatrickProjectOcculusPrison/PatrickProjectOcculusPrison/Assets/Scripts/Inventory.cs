using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
	public GameObject Door;
	public Text text;
	
	private void Start()
	{

		text.text = "";
	}

	private void OnMouseDown()
	{
		if (CompareTag("Key"))
		{
			CollectKey();
		}

		if (CompareTag("Button"))
		{
			PressButton();
		}
	}

	void CollectKey()
	{
		Door.gameObject.GetComponent<BoxCollider>().isTrigger = true;
		text.text = gameObject.name;
		print(gameObject.name+" has been collected");
		transform.position = new Vector3(transform.position.x, 20, transform.position.z);
		gameObject.GetComponent<AudioSource>().Play();
	}

	void PressButton()
	{
		Door.gameObject.GetComponent<BoxCollider>().isTrigger = true;
		print(gameObject.name+" has been pressed");
		gameObject.GetComponent<AudioSource>().Play();
	}
}
