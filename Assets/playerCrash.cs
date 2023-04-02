using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCrash : MonoBehaviour
{
    public GameObject player;
    public GameObject heart;
    public GameObject heart2;
    public GameObject heart3;
    public float r;
    public float playercontroller;
    public static int num=3;
    public PlayerController PlyerController;
    public float playerSize;

    void Start()
    {
        player = GameObject.Find("player");
        this.heart = GameObject.Find("heart");
        this.heart2 = GameObject.Find("heart2");
        this.heart3 = GameObject.Find("heart3");
        r = Random.Range(0.1f, 1.1f);
        transform.localScale = new Vector3(r, r, r);
       

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
        playerSize = PlayerController.size;
        if (d < r1 + r2)
        {
            
            if (playerSize>r)
            {
                Destroy(gameObject);
                playerSize = playerSize + 0.1f;
                PlayerController.size = playerSize;
            }
            if (playerSize < r)
            {
                Destroy(gameObject);
                num--;
            }
          
        }

    }
}
    

