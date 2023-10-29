using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedSelector : MonoBehaviour
{
    public Slider speedSlider;
    public TextMeshProUGUI speedText;
    private int[] availableSpeeds = { 0, 1, 2 };
    private int selectedSpeed = 0;

    private void Start()
    {
        // Initialize the slider and TextMeshPro Text
        speedSlider.minValue = 0;
        speedSlider.maxValue = availableSpeeds.Length - 1;
        UpdateSpeedText((int)speedSlider.value);

        // Add an event listener for the slider value change
        speedSlider.onValueChanged.AddListener(OnSpeedSliderValueChanged);

        // Call MovePlanets every 0.1 seconds (10 times a second)
        InvokeRepeating("MovePlanets", 0f, 0.1f);
    }

    private void UpdateSpeedText(int speed)
    {
        // Update the TextMeshPro Text component
        speedText.text = "Speed: " + speed;
    }

    private void OnSpeedSliderValueChanged(float value)
    {
        // When the slider value changes, update the selected speed
        selectedSpeed = availableSpeeds[Mathf.RoundToInt(value)];
        UpdateSpeedText(selectedSpeed);

    }
    private void MovePlanets()
    {
        if (selectedSpeed == 1) // Add 5 days every 0.1 seconds
        {
            PlanetManager.current.Date = PlanetManager.current.Date.AddDays(5);
        }
        else if (selectedSpeed == 2) // Add 10 days every 0.1 seconds
        {
            PlanetManager.current.Date = PlanetManager.current.Date.AddDays(10);
        }
        // Your code here
        Debug.Log("Function called!");
    }
}
