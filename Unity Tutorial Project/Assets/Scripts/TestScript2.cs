using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript2 : MonoBehaviour

{
    [SerializeField]
    string editorString = "Hello There";
   
    [SerializeField]
    float targetScale = 0;

    Vector3 changingScale = new Vector3(1.0f, 1.0f, 1.0f);

    [SerializeField]
    SpriteRenderer playerSprite = null;

    [SerializeField]
    Color spriteColor = Color.white;


    // Start is called before the first frame update
    void Start()
    {
      //Debug.Log("You have my sword.");
      //Debug.LogWarning("And my bow.");
      //Debug.LogError("And my axe!");

      playerSprite.color = spriteColor;


    //Moves and Rotates object on screen via x, y, z coordinates.
      //transform.Translate(2, 0, 0);

      //transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        targetScale = targetScale + 0.01f;
   //transform.Rotate(0, 0, 15);

     //changingScale.x = targetScale;
     // changingScale.y = targetScale;
     // changingScale.z = targetScale;

        transform.localScale = new Vector3(targetScale, targetScale, targetScale);
    }
}
