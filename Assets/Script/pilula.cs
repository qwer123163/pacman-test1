using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Claim : MonoBehaviour
{

    private Text textToEdit;


    int total = 0;


    void Start()
    {
        textToEdit = GetComponent<Text>();
    }
    public void ChangeText()
    {
        total += 1;
        textToEdit.text = total.ToString();
    }
}