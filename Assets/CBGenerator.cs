using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBGenerator : MonoBehaviour
{
    float span = 3.0f;
    float delta = 0;
    public GameObject cherryPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(cherryPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(-10, px, 0);
        }
    }
}
