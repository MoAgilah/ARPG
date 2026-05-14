using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StatsUI : MonoBehaviour
{
    public GameObject[] statSlots;
    public CanvasGroup statsCanvas;
    private bool statsOpen = false;

    private void Start()
    {
        UpdateAllStats();
        statsCanvas.alpha = statsOpen ? 1 : 0;
    }

    private void Update()
    {
        if (Input.GetButtonDown("ToggleStats"))
        {
            UpdateAllStats();
            statsOpen = !statsOpen;
            Time.timeScale = statsCanvas.alpha = statsOpen ? 1 : 0;
        }
    }

    public void UpdateDamage()
    {
        statSlots[0].GetComponentInChildren<TMP_Text>().text = "Damage: " + StatsManager.instance.damage;
    }

    public void UpdateSpeed()
    {
        statSlots[1].GetComponentInChildren<TMP_Text>().text = "Speed: " + StatsManager.instance.speed;
    }

    public void UpdateAllStats()
    {
        UpdateDamage();
        UpdateSpeed();
    }
}
