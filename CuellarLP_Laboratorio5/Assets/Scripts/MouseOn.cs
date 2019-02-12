using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOn : MonoBehaviour
{
    public Color colorChange; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        Debug.Log("Mouse is on yooooo");

        gameObject.GetComponent<MeshRenderer> ().material.color = colorChange;
        
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse just left dawg");
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }

}
