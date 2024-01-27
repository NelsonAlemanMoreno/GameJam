using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralaex : MonoBehaviour{

    private float length, startpos;
    public GameObject cam;
    public float paralaxEffect;




    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        float dis = (cam.transform.position.x * paralaxEffect);        
    }
}
