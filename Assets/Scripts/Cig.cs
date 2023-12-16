using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cig : MonoBehaviour
{
    [SerializeField] private ParticleSystem smoke;
    [SerializeField] private GameObject cigLit, cigUnlit;

    public void OnClick()
    {
        smoke.Stop();
        cigLit.SetActive(false);
        cigUnlit.SetActive(true);
    }
}
