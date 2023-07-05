using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchScene(6f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SwitchScene(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Mine");
    }
}
