using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Base : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI text;

    string textToChange = "Hello";

    // Encapsulation
    public string textTo
    {
        get { return textToChange; }
    }


    // Start is called before the first frame update
    void Start()
    {
        ChangeText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeText()
    {
        text.text = textTo;
    }
}
