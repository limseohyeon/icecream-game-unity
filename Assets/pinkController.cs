using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkController : MonoBehaviour
{
    public float r;
   
    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(0.009f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(r, 0, 0);
        if (transform.position.x > 9f)
        {
            Destroy(gameObject);
        }
    }
}
