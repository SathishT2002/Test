using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppppppppp : MonoBehaviour
{
    string MyDateFormat = "11-12 -2011 100:00:00";
    //string Name = "";
    // Start is called before the first frame update
    void Start()
    {

        var splitArray = MyDateFormat.Split(" "[0]);
        Debug.Log("Split" + splitArray[0] + "\n" + splitArray[1] + "\n" + splitArray[2]);
    }
}