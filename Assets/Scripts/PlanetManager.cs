using System;
using UnityEngine;
public class PlanetManager : MonoBehaviour
{
    public static PlanetManager current;
    private void Awake()
    {
        if (current == null)
        {
            current = this;
        }
        else
        {
            Destroy(obj: this);
        }
    }

    public event Action<DateTime> OnTimeChange;
    public void TimeChanged(DateTime newTime)
    {
        OnTimeChange?.Invoke(newTime);
    }
    [SerializeField]
    private UDateTime date;
    public UDateTime Date
    {
        get => date;
        set
        {
            date = value;
            TimeChanged(value.dateTime); //Fire the event
        }
    }

}