using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : BaseActionnable
{
    public Transform _baseposition;
    private Quaternion _baserotation;
    private float prevInteractorPosz;

    private void Start()
    {
        
    }

    private void Update()
    {
        RotattionClamp();

    }
    

    protected override void ActionContinue(Transform interactor)
    {
        base.ActionContinue(interactor);
        if (prevInteractorPosz == 0f)
        {
            prevInteractorPosz = interactor.rotation.y;
        }
        float delta = Mathf.Clamp(interactor.rotation.y-prevInteractorPosz,-0.01f,0.01f);
        
        
    }

    private void RotattionClamp()
    {
        _baseposition.localEulerAngles = new Vector3(0f, Mathf.Clamp(0f0f,80f));
    }




}

