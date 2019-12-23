using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{

    public Material ChangingMaterial;
    public Material DefaultMaterial;
    public GameObject defaultObject;




    public void OnButtonClick()
    {
        Debug.Log("Clear the Object");
        defaultObject.GetComponent<MeshRenderer>().material = ChangingMaterial;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
