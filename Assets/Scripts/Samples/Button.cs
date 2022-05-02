using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Button : BaseActionnable
{
   public GameObject light;
   public GameObject EmissiveGameObject;

   protected override void ActionInstant()
   {
      base.ActionInstant();
      if (light.activeInHierarchy)
      {
         light.SetActive(false);
         EmissiveGameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
      }
      else
      {
         light.SetActive(true);
         EmissiveGameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
      }
   }
}
