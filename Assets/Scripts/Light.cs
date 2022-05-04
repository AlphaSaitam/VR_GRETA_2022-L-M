using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light : MonoBehaviour
{
    public GameObject spotlight;
    public GameObject lightobject;
    
    public void Jeteinds()
    {
        Debug.Log("clic1");
        spotlight.SetActive(false);    
        lightobject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        
    }
    
    public void Jallume()
    {
        Debug.Log("clic2");
        spotlight.SetActive(true);    
        lightobject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
}
