using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToggleSize : MonoBehaviour
{
    public TMP_Text buttonText; // R�f�rence au composant TextMeshPro du bouton.

    public SolarSystemController solarSystemController; // R�f�rence au PlanetManager.

    public void ToggleSizes()
    {
        if (solarSystemController != null)
        {
            solarSystemController.ToggleSizes();
            UpdateButtonText();
        }
    }

    private void UpdateButtonText()
    {
        buttonText.text = solarSystemController.showSizes ? "Vue r�aliste" : "Vue adapt�e";
    }
}