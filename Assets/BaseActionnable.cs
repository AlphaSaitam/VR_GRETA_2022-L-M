using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BaseActionnable : MonoBehaviour
{
    public XRSimpleInteractable interactable;
    public bool actionInstantanee = true;
    public bool isSelected = false;
    public Transform interactorPosition;


    private void OnEnable()
    {
      interactable.selectEntered.AddListener(StartSelected);
      interactable.selectExited.AddListener(StopSelected);
    }
    private void OnDisable()
    {
       interactable.selectEntered.RemoveListener(StartSelected);
       interactable.selectExited.RemoveListener(StopSelected);
    }

    protected void StartSelected(SelectEnterEventArgs args)
    {
        if (!actionInstantanee)
        {
            isSelected = true;
            interactorPosition = args.interactorObject.transform;
        }
        else
        {
            ActionInstant();
        }
    }

    protected void StopSelected(SelectExitEventArgs args)
    {
        if (!actionInstantanee)
        {
            isSelected = false;
        }
    }

    protected virtual void ActionInstant()
    {
        
    }

    protected virtual void ActionContinue(Transform interactorblePosition)
    {
        
    }

    private void Update()
    {
        if (isSelected)
        {
            ActionContinue(interactorPosition);
        }
    }
}
