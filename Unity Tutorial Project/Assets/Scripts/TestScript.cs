using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
    
{
    string combinedString;

    [SerializeField]
    string editorString = "Hello";
    // Start is called before the first frame update
    void Start()

    
    {   /*
        Debug.Log("YOU WERE THE CHOSEN ONE!");

        Debug.Log("IT WAS SAID YOU WOULD DESTROY THE SITH, NOT JOIN THEM!");

        Debug.Log("BRING BALANCE TO THE FORCE, NOT LEAVE IT IN DARKNESS");
        */

        string firstString;

        firstString = "You shall not";
        string secondString = " PASS!";
        combinedString = firstString + secondString;

        Debug.Log(combinedString);

        Debug.Log(editorString);

       



        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("YOU WERE MY BROTHER ANAKIN");

        //transform.Translate(0.5f, 0, 0);

        Debug.Log(combinedString); 
    }
}
