using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class TextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }
    
    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString();
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString();
    }
}
