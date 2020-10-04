using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Event handler for the back button 
    public void OnBackButtonPressed()
    {
        Debug.Log("Back Button Pressed");
        SceneManager.LoadScene("Start");
    }
}
