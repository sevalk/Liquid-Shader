using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Animator>().enabled = true;
            

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //gameObject.GetComponent<Animator>().enabled = false;
        }
    }
    public void ChangeObject () {
        object1.gameObject.SetActive(false);
        object2.SetActive(true);
    }
}
