using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("YOU WERE THE CHOSEN ONE!");

        Debug.Log("IT WAS SAID YOU WOULD DESTROY THE SITH, NOT JOIN THEM!");

        Debug.Log("BRING BALANCE TO THE FORCE, NOT LEAVE IT IN DARKNESS");

        transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("YOU WERE MY BROTHER ANAKIN");

        transform.Translate(1, 0, 0);
    }
}
