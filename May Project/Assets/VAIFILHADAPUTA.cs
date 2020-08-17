using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class VAIFILHADAPUTA : MonoBehaviour
{
    private float count;
    public float speedFade;
    private float i = 0f;

    public SpriteRenderer sprite;



  
    // Update is called once per frame
    void Update()
    {
        Invoke("KakaLinda", 2f);

    }


    void KakaLinda()
    {
        count += speedFade * Time.deltaTime;

        sprite.color = new Color(1f, 1f, 1f, 0f);
        
        for(i; i < count; i += 0.1f)
        {
            sprite.color = new Color(1f, 1f, 1f, i);
        } 
    }


    
    
}
