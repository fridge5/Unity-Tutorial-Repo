using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneAll : MonoBehaviour
{

    [SerializeField]
    float spacing = 1f;
    [SerializeField]
    GameObject[] toClone;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < toClone.Length; i++)
        {
            GameObject chosenToClone = null;
            chosenToClone = toClone[i];
            GameObject clonedObject = null;
            clonedObject = Instantiate(chosenToClone);
            Vector3 clonePos = Vector3.zero;
            clonePos = transform.position;
           clonePos.x = i * spacing + clonePos.x;
            clonedObject.transform.position = clonePos;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
