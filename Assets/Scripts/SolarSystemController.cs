using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemController : MonoBehaviour
{
    public bool showTrajectories = false; // État initial : cacher les trajectoires.
    public bool showSizes = false; // État initial : vue réaliste.

    // Start is called before the first frame update
    void Start()
    {
        PlanetManager.current.OnTimeChange += UpdatePosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdatePosition(DateTime t)
    {
        foreach (Transform planet in transform)
        {
            // Check if the child has a specific name and apply changes accordingly
            switch (planet.name)
            {
                case "Mercury":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Mercury, t);
                    break;
                case "Venus":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Venus, t);
                    break;
                case "Earth":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Earth, t);
                    break;
                case "Mars":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Mars, t);
                    break;
                case "Jupiter":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Jupiter, t);
                    break;
                case "Saturn":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Saturn, t);
                    break;
                case "Uranus":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Uranus, t);
                    break;
                case "Neptune":
                    planet.position = PlanetData.GetPlanetPosition(PlanetData.Planet.Neptune, t);
                    break;              
                    
            }
        }
    }

    public void ToggleTrajectories()
    {
        showTrajectories = !showTrajectories;
        if (showTrajectories)
        {
            ShowTrajectories();
        }
        else
        {
            HideTrajectories();
        }
    }

    private void ShowTrajectories()
    {
        // Implémentez le code pour afficher les trajectoires ici.
        Debug.Log("Trajectoires affichées.");
    }

    private void HideTrajectories()
    {
        // Implémentez le code pour cacher les trajectoires ici.
        Debug.Log("Trajectoires cachées.");
    }

    public void ToggleSizes()
    {
        showSizes = !showSizes;
        if (showSizes)
        {
            ShowSizes();
        }
        else
        {
            HideSizes();
        }
    }

    private void ShowSizes()
    {
        // Implémentez le code pour afficher les trajectoires ici.
        Debug.Log("Vue adaptée.");
    }

    private void HideSizes()
    {
        // Implémentez le code pour cacher les trajectoires ici.
        Debug.Log("Vue réaliste.");
    }
}



    

