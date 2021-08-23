using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fill : MonoBehaviour
{
   
    private float t = -0.2f;
    private float waitTime = 0.2f;
    private float timer = 0.0f;
    public float fill;

    public GameObject bottle;
   
   public LıquidColor lıquidColor;
      
       public enum LıquidColor
       {
           Blue,
           Red
       }
      

    public void Filll()
    {
        timer += Time.deltaTime;
       
        if (timer > waitTime)
        {
            timer = 0.0f;
           
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetFloat("_Fill", t);
            t +=  0.02f;

            fill = rend.material.GetFloat("_Fill");
            if (fill >= 0.2f)
            {
                Destroy(bottle);
            }
            
        }
        
    }
}
