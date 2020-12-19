using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayPanel : MonoBehaviour
{   

    public GameObject[] imageObj;
    public AudioSource audioButton;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < imageObj.Length; i++)
        {
            imageObj[i].SetActive(false);
        }

        audioButton = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenButton()
    {
        imageObj[0].SetActive(true);
        imageObj[3].SetActive(true);

    }

    public void NextButton()
    {
        if(imageObj[0].activeInHierarchy)
        {
            imageObj[0].SetActive(false);
            imageObj[1].SetActive(true);
        }

        else if(!imageObj[0].activeInHierarchy && imageObj[1].activeInHierarchy)
        {
            imageObj[1].SetActive(false);
            imageObj[2].SetActive(true);
        }
    }

    public void BackButton()
    {
        if(!imageObj[0].activeInHierarchy && imageObj[1].activeInHierarchy)
        {
            imageObj[1].SetActive(false);
            imageObj[0].SetActive(true);
        }
        else if (!imageObj[1].activeInHierarchy && imageObj[2].activeInHierarchy)
        {
            imageObj[2].SetActive(false);
            imageObj[1].SetActive(true);
        }
    }

    public void CloseButton()
    {
        if(imageObj[0].activeInHierarchy)
        {
            for (int i = 0; i < imageObj.Length; i++)
            {
                imageObj[i].SetActive(false);
            }
        }
        else if(imageObj[1].activeInHierarchy)
        {
            for (int i = 0; i < imageObj.Length; i++)
            {
                imageObj[i].SetActive(false);
            }
        }
        else if(imageObj[2].activeInHierarchy)
        {
            for (int i = 0; i < imageObj.Length; i++)
            {
                imageObj[i].SetActive(false);
            }
        }
    }

    public void sound()
    {
        audioButton.Play();
    }

}
