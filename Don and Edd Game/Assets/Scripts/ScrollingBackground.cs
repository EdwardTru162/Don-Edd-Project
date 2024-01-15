using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed;
    
    private Renderer wallRenderer;
    private Vector2 savedOffset;
    void Start()
    {
       wallRenderer = GetComponent<Renderer> (); 
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Repeat (Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2 (x, 0);
        wallRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
        
    }
}
