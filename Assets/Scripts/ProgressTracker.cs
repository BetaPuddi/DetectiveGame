using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{
    public static ProgressTracker instance;

    public int cluesFound = 0;

    private void Awake()
    {
        instance = this;
    }

    public void AddClue()
    {
        cluesFound++;
    }

}
