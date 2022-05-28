using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDir : MonoBehaviour
{
    public float  speed = 2;
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x > 50)
            speed *= (-1);
        if (gameObject.transform.position.x < 50)
            speed *= (-1);

        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
   
}
