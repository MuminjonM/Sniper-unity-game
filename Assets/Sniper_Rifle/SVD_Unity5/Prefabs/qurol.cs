using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class qurol : MonoBehaviour
{
    public Vector2 Pos;
    public GameObject oqChiqishJoyi, oq,camera;
    float distance = 0;
    public GameObject can;
    public Text ochko,ulgan;
    public int och = 0, ul = 0;
    public GameObject[] bots,bots1;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        can.active = false;
        Pos.x = -90;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (och == 1)
        {
            foreach (GameObject o in bots)
            {
                o.GetComponent<bot1>().otish=true; 
            }
            foreach (GameObject o in bots1)
            {
                o.GetComponent<bot>().otish = true;
            }

        }
        Pos.x += Input.GetAxis("Mouse X");
        Pos.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(0f, Pos.x, -Pos.y);
        if (camera.GetComponent<Camera>().fieldOfView < 40)
        {
            can.SetActive(true);
        }
        else { can.SetActive(false); }

        
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            camera.GetComponent<Camera>().fieldOfView--;

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            camera.GetComponent<Camera>().fieldOfView++;

        }
        RaycastHit hit;
            Ray ray = new Ray(oqChiqishJoyi.transform.position,-oqChiqishJoyi.transform.right);
           
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);
            
        if (Input.GetMouseButtonDown(0))
        {
            och++;
           audio.Play();
            if (Physics.Raycast(ray, out hit,1000))
            {
                Debug.Log(hit.transform.name);
                if (hit.collider.transform.tag == "bot")
                {
                    if (hit.collider.transform.GetComponent<bot>().ulish == false)
                        ul++;
                    hit.collider.transform.GetComponent<bot>().ulish=true;
                }
                if (hit.collider.transform.tag == "bot1")
                {
                    if (hit.collider.transform.GetComponent<bot1>().ulish == false)
                        ul++;
                    hit.collider.transform.GetComponent<bot1>().ulish = true;
                }
            }
        }
        ochko.text=och.ToString();
        ulgan.text=ul.ToString();
    }
}
