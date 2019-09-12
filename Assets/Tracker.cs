using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
public class Tracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ViveInput.GetPressDown(GetComponent<ViveRoleSetter>().viveRole , ControllerButton.Trigger))
        {
            Debug.Log("trigger");
        }
    }
}
