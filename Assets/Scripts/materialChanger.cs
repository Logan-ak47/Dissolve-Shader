using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialChanger : MonoBehaviour
{
    public Material ChangingMaterial;
    public Material DefaultMaterial;
    public GameObject defaultObject;




    public void OnButtonClick()
    {
        Debug.Log("Clear the Object");
        defaultObject.GetComponent<MeshRenderer>().material = ChangingMaterial;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
