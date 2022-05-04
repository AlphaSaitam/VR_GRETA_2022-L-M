using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Tiroir : BaseActionnable
{
  private Vector3 _baseposition;
  private Quaternion _baserotation;
  private float prevInteractorPosz;

  private void Start()
  {
    _baseposition = transform.position;
    _baserotation = transform.rotation;
  }

  protected override void ActionContinue(Transform interactor)
  {
      base.ActionContinue(interactor);
      if (prevInteractorPosz == 0f)
      {
          prevInteractorPosz = interactor.position.z;
      }
      float delta = Mathf.Clamp(interactor.position.z-prevInteractorPosz,-0.01f,0.01f);
      
      prevInteractorPosz = interactor.position.z;
          
      transform.rotation = _baserotation;
      transform.position = new Vector3(_baseposition.x, _baseposition.y, Mathf.Clamp(transform.position.z + delta, _baseposition.z-1f, _baseposition.z));
  }
}
