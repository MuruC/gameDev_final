﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MineWarningText : MonoBehaviour
{
    public GameObject warningTextCanvas;
    /*
    public GameObject warningTextCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        warningTextCanvas.SetActive(true);
    }

    private void OnMouseExit()
    {
        warningTextCanvas.SetActive(false);
    }

    private void OnMouseOver()
    {
        Debug.Log("mouseOverWarning!");
    }
    */
    public SpriteRenderer rend;

    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // The mesh goes red when the mouse is over it...
    void OnMouseEnter()
    {
        //rend.color = Color.red;
        //warningTextCanvas.SetActive(true);
    }

    // ...the red fades out to cyan as the mouse is held over...
    void OnMouseOver()
    {
        //rend.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
        warningTextCanvas.SetActive(true);
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        //rend.color = Color.white;
        warningTextCanvas.SetActive(false);
    }
}
