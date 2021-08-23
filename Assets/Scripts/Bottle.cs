using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    
    
    float movedownY = 0.0f;
    float sensitivityY = 20f;
    private bool test = true;
    Bottle t = null;
    private void Update() 
    {
        InteractWithCombat();
        
    }

    private void InteractWithCombat()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
        if (hasHit)
        {
            Bottle target = null;
            if (test)
            {
                target = hit.transform.GetComponent<Bottle>();
               
            }
            else
            {
                target = t;
            }
           
            
                
            //if (!GetComponent<Bottle>().) continue;
            if (Input.GetMouseButtonDown(0) && target)
            {
                target.GetComponent<Animation>().Play();
            }
            if (Input.GetMouseButton(0) && target)
            {
                   t = target;
                   test = false;
                   //target.GetComponent<Animation>().enabled = true;
                    movedownY += Input.GetAxis("Mouse X") * sensitivityY *Time.deltaTime;
                    if (Input.GetAxis("Mouse X") != 0){
                        target.transform.Translate(new Vector3(0,0,-1) * movedownY , Space.World );
                        // target.transform.position = Vector3.Lerp(transform.position,new Vector3(0,1,0) * movedownY, 1f * Time.deltaTime);
                
                    }
                    movedownY = 0.0f;
                 
            }

            if (Input.GetMouseButtonUp(0))
            {
               
                test = true;
            }
            
        }
      
    }
    private static Ray GetMouseRay()
    {
        return Camera.main.ScreenPointToRay(Input.mousePosition);
    }

}
