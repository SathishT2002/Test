using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject ImageClick;
    //public Button Clickbtn;

    // Start is called before the first frame update
    
    void Start()
    {
        //Clickbtn.onClick.AddListener(() => StartCoroutine(ImageSetTrue()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImageSetActive()
    {
        if(ImageClick.activeSelf)
            ImageClick.SetActive(false);
        else
            ImageClick.SetActive(true);
    }
    public void ImageSetfales()
    {
        ImageClick.SetActive(true);
    }
}
