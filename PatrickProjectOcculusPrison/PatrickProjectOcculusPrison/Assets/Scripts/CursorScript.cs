using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CursorScript : MonoBehaviour
{
	// Use this for initialization
	void Start(){}

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "EndScreen")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;
        }
    }
}