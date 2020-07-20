using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIOperation : MonoBehaviour
{
    public Text label;
    // Start is called before the first frame update
    void Start()
    {
        label.text = "My first text";
    }

    // Update is called once per frame
    public void ChangeText()
    {
        label.text = "Changed text";
    }
}
