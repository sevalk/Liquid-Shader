using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spill : MonoBehaviour
{
    ParticleSystem _particleSystem;

    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        //mat = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 90f)
        {
           // _particleSystem.Play();
           mat.SetFloat("Fill" , 0f);
           
        }
        else
        {
            mat.SetFloat("Fill" , -1f);
            //_particleSystem.Stop();
        }
    }
}
