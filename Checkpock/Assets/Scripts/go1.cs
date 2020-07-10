using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go1 : MonoBehaviour
{
    // Start is called before the first frame update
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
            transform.Translate(Vector3.up * Time.deltaTime);
            if(timer >= 0.5f)
            {
            up = true;
            timer = 0;
            }
        }  

        else if(up)
        {
            transform.Translate(Vector3.up * -1 * Time.deltaTime);
            if(timer >= 0.5f)
            {
            up = false;
            timer = 0;
            }
        }
    }
}

