using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharryCrash : MonoBehaviour
{
    GameObject player;
    public playerCrash pc;
    int x;
    public static int cherry=0;


    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        x = playerCrash.num;
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
        if (d < r1 + r2)
        {
           
            Destroy(gameObject);
           switch (x)
            {
                case 2:
                    cherry = 1;
                    break;
                case 1:
                    cherry = 2;
                    break;
            }
            Debug.Log(playerCrash.num);
            playerCrash.num++;

        }
    }
}
