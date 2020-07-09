using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class particles : MonoBehaviour
{
    public VisualEffect myEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        myEffect.Play();

    }

    // Update is called once per frame
    void Update()
    {
    }
}
