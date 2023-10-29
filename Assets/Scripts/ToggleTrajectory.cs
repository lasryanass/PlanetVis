using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToggleTrajectory : MonoBehaviour
{
    public TMP_Text buttonText; // R�f�rence au composant TextMeshPro du bouton.

    public SolarSystemController solarSystemController; // R�f�rence au PlanetManager.

    public void ToggleTrajectories()
    {
        if (solarSystemController != null)
        {
            solarSystemController.ToggleTrajectories();
            UpdateButtonText();
        }
    }

    private void UpdateButtonText()
    {
        buttonText.text = solarSystemController.hideTrajectories ? "Afficher Trajectoire" : "Cacher Trajectoire";
    }
}