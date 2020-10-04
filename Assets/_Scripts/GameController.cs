using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public TMP_Text SceneLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                SceneLabel.text = "Portrait";

                break;

            case DeviceOrientation.LandscapeLeft:
                SceneLabel.text = "Landscape Left";

                break;

            case DeviceOrientation.LandscapeRight:
                SceneLabel.text = "Landscape Right";

                break;

            case DeviceOrientation.Unknown:
                SceneLabel.text = "Unknown";

                break;

            default:
                SceneLabel.text = "Default Switch State";

                break;
        }
    }
}
