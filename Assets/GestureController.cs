using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureController : MonoBehaviour
{
    public GameObject tomato;
    public GameObject cutTomato;
    public GameObject pepper;
    public GameObject cutPepper;
    public Transform spawnTransform;

    public ActiveStateSelector gestureThumbsUp;
    public ActiveStateSelector gestureScissors;

    // Start is called before the first frame update
    void Start()
    {
        tomato.SetActive(true);
        cutTomato.SetActive(false);
        gestureScissors.WhenSelected += () => tomato.SetActive(false);
        gestureScissors.WhenSelected += () => cutTomato.SetActive(true);



        gestureScissors.WhenSelected += () =>
        {
            if (cutTomato.GetComponent<Food>().getEntered())
            {
                pepper.SetActive(false);
                cutPepper.SetActive(true);
            }
        };

     
        
        //gestureScissors.WhenSelected += () => SpawnPrefab(cutTomato);
        //gestureThumbsUp.WhenSelected += () => SpawnPrefab(cutTomato);
        // gestureScissors.WhenSelected += () => SpawnPrefab(prefabSphere);
    }

    void SpawnPrefab(GameObject cutTomato)
    {
        Instantiate(cutTomato, spawnTransform.position, spawnTransform.rotation);
    }
}
