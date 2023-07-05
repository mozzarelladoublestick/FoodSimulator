using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food : MonoBehaviour
{
    public bool entered;
    public Text debugtext;

    // Start is called before the first frame update
    void Start()
    {
        entered = false;

    }

    // Update is called once per frame
  

    public bool getEntered()
    {
        return entered;
    }
    public void setEntered(bool enter)
    {
        entered = enter;
    } 

}
