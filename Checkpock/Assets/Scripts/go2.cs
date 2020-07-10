using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go2 : MonoBehaviour
{
    public bool up;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(!up)
        {
            transform.Rotate (Vector3.up * -500 * Time.deltaTime);
            if(timer >= 1f)
            {
            up = true;
            timer = 0;
            }
        }  

        else if(up)
        {
            transform.Rotate (Vector3.up * 500 * Time.deltaTime);
            if(timer >= 1f)
            {
            up = false;
            timer = 0;
            }
        }
    }
}
