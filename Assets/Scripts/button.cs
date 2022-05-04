using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class button : BaseActionnable
{
    public GameObject _light;
    public Renderer _Emissive;
    public bool islighton = false;

    



    public void Lightactive()
    {
        if (islighton)
        {
            Debug.Log("tortue");
            _light.SetActive(false);
            _Emissive.material.DisableKeyword("_EMISSION");
            islighton= !islighton;
            Debug.Log("cougar");
            
        }
        else
        {
            Debug.Log("chatte");
            _light.SetActive(true);
            _Emissive.material.EnableKeyword("_EMISSION");
            islighton = !islighton;
            Debug.Log("chaton");
        }
    }
}
