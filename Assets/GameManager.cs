using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int x;
    int y;
    float size;
    public GameObject Image;
    public GameObject Image2;
    public GameObject Image3;
    public playerCrash pc;
    public CharryCrash cc;
    public PlayerController playerController;


    // Start is called before the first frame update
    void Start()
    {
        Image.GetComponent<Image>().enabled = true;
        Image2.GetComponent<Image>().enabled = true;
        Image3.GetComponent<Image>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        x = playerCrash.num;
        y = CharryCrash.cherry;
        size = PlayerController.size;
        switch (x)
        {
            case 2:
                Image.GetComponent<Image>().enabled=false;
                break;
            case 1:
                Image2.GetComponent<Image>().enabled = false;
                break;
            case 0:
                Image3.GetComponent<Image>().enabled = false;
                SceneManager.LoadScene("FailScene");

                
                break;
        }
        switch (y)
        {
            case 1:
                Image.GetComponent<Image>().enabled = true;
                break;
            case 2:
                Image2.GetComponent<Image>().enabled = true;
                break;
        }
        CharryCrash.cherry = 0;

        if (size >1.1f)
        {
            x = 3;
            y = 0;
            Image.GetComponent<Image>().enabled = true;
            Image2.GetComponent<Image>().enabled = true;
            Image3.GetComponent<Image>().enabled = true;
            PlayerController.size = 0.4f;
            SceneManager.LoadScene("SuccessScene");
        }
    }
}
