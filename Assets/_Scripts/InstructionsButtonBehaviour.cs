using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsButtonBehaviour : MonoBehaviour
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
    public void OnInstructionsButtonPressed()
    {
        Debug.Log("Instructions Button Pressed");
        SceneManager.LoadScene("Instructions");
    }
}
