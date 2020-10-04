using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Event handler for the start button 
    public void OnNextButtonPressed()
    {
        Debug.Log("Next Button Pressed");
        SceneManager.LoadScene("End");
    }
}
