using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rend : MonoBehaviour
{
public SpriteRenderer sprender;

    // Start is called before the first frame update
    void Start()
    {
        sprender = gameObject.GetComponent<SpriteRenderer>();
        sprender.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
