using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    /*  public  GameObject[] Doors;            //Door that is locked and must be unlocked
      public  GameObject[] PrimaryKeys;      //Key to unlock each door
      public  GameObject[] SecondaryKeys;    //
      public  GameObject[] TertiaryKeys;     //
      private bool[]       Unlocking; 
      
      //TODO: Create a public array, for all objects to collect, with Boolean of are they used.
      //TODO: Create a public array of all associated doors, and their keys, with Boolean locked.
      //TODO: Create an array of text.
  
      // Use this for initialization
      void Start () {
          //Check for errors and yell them
          if (Doors.Length != PrimaryKeys.Length)
          {
              print("Error in the primary keys or doors");
  
          }else if (SecondaryKeys.Length > PrimaryKeys.Length)
          {
              print("Too many secondaries");
  
          }else if (TertiaryKeys.Length > SecondaryKeys.Length)
          {
              print("Too many tertiaries");
  
          }
          
          Unlocking = new bool[Doors.Length];
          
          foreach (var door in Doors)
          {
              door.SetActive(true);
          }
          foreach (var key in PrimaryKeys)
          {
              key.SetActive(true);
          }
          foreach (var key in SecondaryKeys)
          {
              key.SetActive(true);
          }
          foreach (var key in TertiaryKeys)
          {
              key.SetActive(true);
          }
          for (int i = 0; i < Unlocking.Length; i++)
          {
              Unlocking[i] = false;
          }
      }
  
      // Update is called once per frame
      void Update () {
          foreach (var key in PrimaryKeys)
          {
              if (-100 == key.transform.position.y && key.GetComponent<AudioSource>().isPlaying == false)
              {
                  key.SetActive(false);
              }    
          }
          foreach (var key in SecondaryKeys)
          {
              if (-100 == key.transform.position.y && key.GetComponent<AudioSource>().isPlaying == false)
              {
                  key.SetActive(false);
              }    
          }
          foreach (var key in TertiaryKeys)
          {
              if (-100 == key.transform.position.y && key.GetComponent<AudioSource>().isPlaying == false)
              {
                  key.index;
               
                  Doors[key].SetActive(false);
                  key.SetActive(false);
              }    
          }
      }
      
      private void OnMouseDown()
      {
          print("Key Collected");
          transform.position = new Vector3(transform.position.x, -100, transform.position.z);
          GetComponent<AudioSource>().Play();
      } 
  */
}