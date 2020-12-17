using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameController : MonoBehaviour
{
    public InputField nameField;
    public string nameText;
    public GameObject warning;    
    // Start is called before the first frame update
    void Start()
    {        
        nameField.text = "";
        warning.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        nameText = nameField.text;
        Debug.Log(nameField.text);
    }
}
