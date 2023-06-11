using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerResize : MonoBehaviour
{
    public GameObject playerBar1;
    public GameObject playerBar2;

    // Start is called before the first frame update
    void Start()
    {
        playerBar1 = GameObject.Find("Bar1");
        playerBar2 = GameObject.Find("Bar2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResizeUp(int tag)
    {
        if (tag == 1)
        {
            playerBar1.transform.localScale = new Vector3(25,5,3);
        }
        else if (tag == 2)
        {
            playerBar2.transform.localScale = new Vector3(25,5,3);
        }
    }

    public void ResizeNormal(int tag)
    {
        if (tag == 1)
        {
            playerBar1.transform.localScale = new Vector3(20,5,3);
        }
        else if (tag == 2)
        {
            playerBar2.transform.localScale = new Vector3(20,5,3);
        }
    }

    public void ResizeDown(int tag)
    {
        if (tag == 1)
        {
            playerBar1.transform.localScale = new Vector3(13,5,3);
        }
        else if (tag == 2)
        {
            playerBar2.transform.localScale = new Vector3(13,5,3);
        }
    }
}
