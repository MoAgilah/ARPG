using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public TMP_Text healthTxt;
    public Animator healthTxtAnim;

    private void Start()
    {
        healthTxt.text = "HP: " + StatsManager.instance.currentHealth + " / " + StatsManager.instance.maxHealth;
    }

    public void ChangeHealth(int amount)
    {
        StatsManager.instance.currentHealth += amount;

        healthTxtAnim.Play("TextUpdate");

        healthTxt.text = "HP: " + StatsManager.instance.currentHealth + " / " + StatsManager.instance.maxHealth;


        if (StatsManager.instance.currentHealth > StatsManager.instance.maxHealth)
            StatsManager.instance.currentHealth = StatsManager.instance.maxHealth;
        else if (StatsManager.instance.currentHealth <= 0)
            gameObject.SetActive(false);
    }
}
