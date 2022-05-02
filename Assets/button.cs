using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;
using Button = UnityEngine.UI.Button;

public class button : MonoBehaviour
{
    public XRSimpleInteractable _button;
    public Light light;
    public bool lightON = false;
    
    
    public void OnEnable()
    {
        _button.selectEntered.AddListener(Clicked);
    }

    public void OnDisable()
    {
        _button.selectExited.RemoveListener(Clicked);
    }

   public void Clicked(SelectEnterEventArgs args)
    {
        if (lightON)
        {
            lightON = false;
            light.Jeteinds();
        }
        else
        {
            lightON = true;
            light.Jallume();
        }
    }
   
   public void Clicked(SelectExitEventArgs args)
   {
       
   }

}
