using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bot : MonoBehaviour
{
    public Animation anim;
    public AudioSource aud;
    public bool ulish = false,flag=true,otish=false;
    public GameObject[] tar;
    public int item = 0,speed=3;
    public GameObject svd;
    public float t = 0, dis = 3;
    // Start is called before the first frame update
    void Start()
    {
        aud=GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (!ulish)
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
            else
        if (Vector3.Distance(tar[item].transform.position, transform.position) > 3)
        {
            transform.LookAt(tar[item].transform);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            anim.CrossFade("walk");
        }
        else
        {
            if (item < tar.Length - 1)
                item++;
            else item = 0;
        }



        if (ulish&&flag)
        {
            anim.CrossFade("death");
            flag = false;
        }
      

    }
}
