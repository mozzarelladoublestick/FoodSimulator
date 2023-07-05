using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Frying : MonoBehaviour
{
    public GameObject rawMeat;
    public GameObject cookedMeat;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        rawMeat.SetActive(true);
        cookedMeat.SetActive(false);
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "rawMeat")
        {
            fire.SetActive(true);
            cookedMeat.SetActive(true);
            rawMeat.SetActive(false);
        ;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Meat")
        {
            fire.SetActive(false);
        }
    }

}