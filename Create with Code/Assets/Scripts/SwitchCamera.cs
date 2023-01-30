using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    public Camera mainCamera;
    public Camera fpvCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        fpvCamera.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            fpvCamera.enabled = !fpvCamera.enabled;
        }
        
    }
}
