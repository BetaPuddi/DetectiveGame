using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ThoughtText : MonoBehaviour
{
    public static ThoughtText instance;

    void Awake()
    {
        instance = this;
    }

    public void SetText(string text)
    {
        GetComponent<TextMeshProUGUI>().text = text;
    }
}
