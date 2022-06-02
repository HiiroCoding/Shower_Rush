using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiScript : MonoBehaviour
{
    public TextMeshProUGUI pressE;
    public TextMeshProUGUI exit;

    public void AppearingText()
    {
        pressE.enabled = true;
    }

    public void DissappearingText()
    {
        pressE.enabled = false;
    }
}
