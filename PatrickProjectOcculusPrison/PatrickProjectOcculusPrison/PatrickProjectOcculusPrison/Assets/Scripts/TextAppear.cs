using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour {
	public Text text;
	public string information;
	// Use this for initialization
	void Start () {
		text.text = "";
	}

	void OnTriggerEnter(Collider other){
		if(other.CompareTag ("Player")){
			text.text = information;
		}
	}

	void OnTriggerExit(){
		text.text = "";
	}
}