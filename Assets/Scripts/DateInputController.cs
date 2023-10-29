using UnityEngine;
using TMPro;
using System;

public class DateInputController : MonoBehaviour
{
    public TMP_InputField dateInputField;
    public TMP_Text dateDisplayText;
    private UDateTime uDateTime;

    private void Start()
    {
        uDateTime = new UDateTime();
    }

    public void OnDateInputEndEdit(string newDate)
    {
        // Handle the date input change when End Edit event is triggered
        if (DateTime.TryParse(newDate, out DateTime parsedDate))
        {
            uDateTime = parsedDate;
            PlanetManager.current.Date = uDateTime; // Notify PlanetManager of the date change

        }
        else
        {
            Debug.LogError("Invalid date format.");
        }

        dateDisplayText.text = uDateTime.ToString("MM/dd/yyyy");
    }
}
