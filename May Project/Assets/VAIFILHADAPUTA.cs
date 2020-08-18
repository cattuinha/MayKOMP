using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class VAIFILHADAPUTA : MonoBehaviour
{
   
    SpriteRenderer rend;


    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;
        Invoke("ComecarCorotina", 8.5f);
    }
  
    // Update is called once per frame    

    void ComecarCorotina()
    {
        StartCoroutine("KakaLinda");
    }

    IEnumerator KakaLinda()
    {
                
        for(float f = 0f; f <= 1; f += 0.001f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.001f);
        } 
    }


    
    
}
