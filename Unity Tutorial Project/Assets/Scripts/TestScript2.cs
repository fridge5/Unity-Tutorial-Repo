using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You have my sword.");
        Debug.LogWarning("And my bow.");
        Debug.LogError("And my axe!");

    //Moves and Rotates object on screen via x, y, z coordinates.
        transform.Translate(2, 0, 0);

        transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 15);
    }
}
