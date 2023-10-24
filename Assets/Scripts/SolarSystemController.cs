using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystemController : MonoBehaviour
{

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
}
