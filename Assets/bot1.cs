using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot1 : MonoBehaviour
{

    public Animation anim;
    public bool otish = false, ulish = false,flag=true;
    public AudioSource aud;
    public float t = 0,dis=3;
    public GameObject svd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (!ulish)
        {
            if (otish)
            {
                transform.LookAt(svd.transform);
                anim.CrossFade("shoot");
                if (t > dis)
                {
                    aud.Play();
                    t = 0;
                }
                
            }


        }
        else
        {
            if (flag)
            {
                anim.CrossFade("death");
                flag = false;
            }
        }
        
    }
}
