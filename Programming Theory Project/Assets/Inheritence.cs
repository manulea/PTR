using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inheritence : Base
{
    // Start is called before the first frame update
    void Start()
    {
        // Inheritance
        Debug.Log(base.textTo);
        base.text.text = textTo;

        // Polymorphism
        TextChange();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Abstraction
    void TextChange()
    {
        base.text.text = "Yesterday";
    }
}
