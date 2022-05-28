using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odam : MonoBehaviour
{
    public Animation anim;
    public int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            anim.Play("RunForward");
            // CrossFade(string animation, float fadeLength = 0.3F, PlayMode mode = PlayMode.StopSameLayer);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
            anim.CrossFade("RunBackward");
        }
        else
        {
            anim.Play("IdleCrouching");
        }
        


    }
}
