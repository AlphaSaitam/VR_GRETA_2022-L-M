using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.XR.Interaction.Toolkit;

public class Wall : BaseActionnable

{
    public Color baseColor ;
    private Color[] colorArray =new Color[]{Color.clear, Color.cyan, Color.blue,Color.white};
    private int i;

    private void Start()
    {
        colorArray[0] = gameObject.GetComponent<Renderer>().material.GetColor("_BaseColor");
        i = 1;
    }


    public void ColorSwap()
    {
        if (gameObject.CompareTag("ColorSwappable"))
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_BaseColor",colorArray[i]);
            i++;
            if (i >= colorArray.Length)
            {
                i = 0;
            }
        }
            
        
    }
    
    }


