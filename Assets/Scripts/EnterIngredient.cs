using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnterIngredient : MonoBehaviour
{
    public Text debugtext;
    public Text recipetitle;
    public Text recipe;
    public Text ui;
    public GameObject bread1;
    public GameObject salad;
    public GameObject tomato;
    public GameObject meat;
    public GameObject pepper;
    public GameObject bread2;
    public GameObject burger;
    public GameObject middleOfTray;
    AudioSource audioData;
    AudioSource game;
    public Text done;
    public static bool finished;

   
        // Start is called before the first frame update
        void Start()
    {
            audioData = GetComponent<AudioSource>();


        burger.SetActive(false);
        game.Play(0);


    }

    // Update is called once per frame
    void Update()
    {
      
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
       
    }
    IEnumerator HideUITextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        ui.text = ""; 
    }
    IEnumerator QuitGame(float delay)
    {
        yield return new WaitForSeconds(delay);
        Application.Quit();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bread" && !(bread1.GetComponent<Food>().getEntered()) )
        {
            debugtext.text = "entered bread";
            bread1.GetComponent<Food>().setEntered(true);
          //  bread1.GetComponent<Food>().transform.position = middleOfTray.transform.position;
            audioData.Play(0);
            done.text = "-------";
            ui.text = "";

        }
        else if ((other.tag == "Salad") && (bread1.GetComponent<Food>().getEntered())&&!(salad.GetComponent<Food>().getEntered()))
        {
            debugtext.text = "entered salad";
            salad.GetComponent<Food>().setEntered(true);
           // salad.GetComponent<Food>().transform.position = middleOfTray.transform.position;
            audioData.Play(0);
            done.text = "------ \n ------";

        }
        else if (other.tag == "uncut")
        {
            ui.text = "Cut first using a scissor gesture!";
            StartCoroutine(HideUITextAfterDelay(4f));

        }
        else if (other.tag == "rawMeat")
        {
            ui.text = "Cook the meat in the pan to your right!";
            StartCoroutine(HideUITextAfterDelay(4f));

        }
        else if ((other.tag == "Tomato") && (salad.GetComponent<Food>().getEntered()) && !(tomato.GetComponent<Food>().getEntered()))
        {
            debugtext.text = "entered Tomato";
            tomato.GetComponent<Food>().setEntered(true);
            //tomato.GetComponent<Food>().transform.position = new Vector3(0,0,0);
           // tomato.GetComponent<Food>().transform.position = middleOfTray.transform.position;
            audioData.Play(0);
            done.text = "---- \n ------\n -------";

        }
        else if ((other.tag == "Meat") && (tomato.GetComponent<Food>().getEntered()) && !(meat.GetComponent<Food>().getEntered()))
        {
            debugtext.text = "entered Meat";
            meat.GetComponent<Food>().setEntered(true);
            //meat.GetComponent<Food>().transform.position = middleOfTray.transform.position;
            audioData.Play(0);
            done.text = "---- \n ------\n -------\n--------";
        }
        else if ((other.tag == "Pepper") && (meat.GetComponent<Food>().getEntered()) && !(pepper.GetComponent<Food>().getEntered()))
        {
            debugtext.text = "entered Pepper";
            pepper.GetComponent<Food>().setEntered(true);
           // pepper.GetComponent<Food>().transform.position = middleOfTray.transform.position;
            audioData.Play(0);
            done.text = "---- \n ------\n -------\n--------\n-------";

        }
        else if ((other.tag == "Bread2") && (pepper.GetComponent<Food>().getEntered()) && !(bread2.GetComponent<Food>().getEntered())) //fix meat
        {
            done.text = "";
            debugtext.text = "YOU FINISHED THE BURGER";
            bread2.GetComponent<Food>().setEntered(true);
            //bread2.GetComponent<Food>().transform.position = middleOfTray.transform.position;
            audioData.Play(0);
            ui.text = "You did it!!";
            bread1.SetActive(false);
            salad.SetActive(false);
            tomato.SetActive(false);
            meat.SetActive(false);
            pepper.SetActive(false);
            bread2.SetActive(false);
            burger.SetActive(true);
            recipe.text = "";
            recipetitle.text = "YOU DID IT";
            finished = true;
            QuitGame(5f);

        }
    }
}
