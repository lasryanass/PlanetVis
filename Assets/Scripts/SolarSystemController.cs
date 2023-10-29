using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SolarSystemController : MonoBehaviour
{
    public bool hideTrajectories = false; // État initial : afficher les trajectoires.
    public bool showSizes = false; // État initial : vue réaliste.
    public float scaleMultiplier = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        PlanetManager.current.OnTimeChange += UpdatePosition;

        UpdatePosition(DateTime.Now);
        DrawTrajectories(Color.red); // On affiche les trajectoires au début

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
        hideTrajectories = !hideTrajectories;
        if (hideTrajectories)
        {
            HideTrajectories();
        }
        else
        {
            ShowTrajectories();
        }
    }

    private void ShowTrajectories()
    {
        foreach (Transform planet in transform)
        {
            switch (planet.name)
            {
                case "Mercury":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                case "Venus":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                case "Earth":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                case "Mars":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                case "Jupiter":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                case "Saturn":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                case "Uranus":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                case "Neptune":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = true;
                    break;
                default:
                    break;

            }
        }
        // Implémentez le code pour afficher les trajectoires ici.
        Debug.Log("Trajectoires affichées.");
    }

    private void HideTrajectories()
    {
        foreach (Transform planet in transform)
        {
            switch (planet.name)
            {
                case "Mercury":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                case "Venus":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                case "Earth":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                case "Mars":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                case "Jupiter":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                case "Saturn":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                case "Uranus":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                case "Neptune":
                    planet.gameObject.GetComponent<LineRenderer>().enabled = false;
                    break;
                default:
                    break;

            }
        }
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
        foreach (Transform planet in transform)
        {
            // Check if the child has a specific name and apply changes accordingly
            switch (planet.name)
            {
                case "Sun":
                    planet.localScale *= scaleMultiplier;
                    break;
                case "Mercury":
                    planet.localScale *= scaleMultiplier;
                    break;
                case "Venus":
                    planet.localScale *= scaleMultiplier;                   
                    break;
                case "Earth":
                    planet.localScale *= scaleMultiplier;
                    break;
                case "Mars":
                    planet.localScale *= scaleMultiplier;
                    break;
                case "Jupiter":
                    planet.localScale *= scaleMultiplier;
                    break;
                case "Saturn":
                    planet.localScale *= scaleMultiplier;
                    break;
                case "Uranus":
                    planet.localScale *= scaleMultiplier;
                    break;
                case "Neptune":
                    planet.localScale *= scaleMultiplier;
                    break;
                default:
                    break;

            }
        }
        // Implémentez le code pour afficher les trajectoires ici.
        Debug.Log("Vue adaptée.");
    }

    private void HideSizes()
    {
        foreach (Transform planet in transform)
        {
            // Check if the child has a specific name and apply changes accordingly
            switch (planet.name)
            {
                case "Sun":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Mercury":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Venus":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Earth":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Mars":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Jupiter":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Saturn":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Uranus":
                    planet.localScale /= scaleMultiplier;
                    break;
                case "Neptune":
                    planet.localScale /= scaleMultiplier;
                    break;
                default:
                    break;

            }
        }
        // Implémentez le code pour cacher les trajectoires ici.
        Debug.Log("Vue réaliste.");
    }

    private void DrawTrajectories(Color color)
    {
        float distance = 0;
        foreach (Transform planet in transform)
        {
            // Check if the child has a specific name and apply changes accordingly
            switch (planet.name)
            {
                case "Mercury":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                case "Venus":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                case "Earth":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                case "Mars":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                case "Jupiter":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                case "Saturn":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                case "Uranus":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                case "Neptune":
                    distance = Vector2.Distance(Vector2.zero, new Vector2(planet.position.x, planet.position.y));
                    DrawTrajectory.DrawCircle(planet.gameObject, Vector2.zero, distance, color, planet.position.z);
                    break;
                default:
                    break;

            }
        }
    }
}