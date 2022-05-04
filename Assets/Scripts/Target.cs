using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
   [SerializeField] private int _score;
    public Text scoreText;
    
    void Start()
    {
        _score = 0;
        
    }

    private void FixedUpdate()
    {
        Scorecheck();
 
    }



    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("touché");

        if (other.collider.gameObject.CompareTag("ball"))
        {   
            Debug.Log("marchefdp");
           _score++;
        }
    }

    private void Scorecheck()
    
    {
        if (_score >= 999)
        {
            _score = 0;
        }
        if (_score >= 100)
        {
            scoreText.text =  _score.ToString();
        }
        else if (_score >= 10)
        {
            scoreText.text = "0" + _score;
        }
        else
        {
            scoreText.text = "00" + _score;
        }

        

    }
}
