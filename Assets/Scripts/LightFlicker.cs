using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light myLight;
    public float maxInterval = 1;
    public float maxFlicker = 0.2f;

    private float _defaultIntensity;
    private bool _isOn;
    private float _timer;
    private float _delay;

    private void Start()
    {
        _defaultIntensity = myLight.intensity;
    }

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            ToggleLight();
        }
    }

    void ToggleLight()
    {
        _isOn = !_isOn;
        if (_isOn)
        {
            myLight.intensity = _defaultIntensity;
            _delay = Random.Range(0, maxInterval);
        }
        else
        {
            myLight.intensity = Random.Range(0.6f, _defaultIntensity);
            _delay = Random.Range(0, maxFlicker);
        }
        _timer = 0;
    }
}
