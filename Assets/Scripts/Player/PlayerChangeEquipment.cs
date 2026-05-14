using UnityEngine;

public class PlayerChangeEquipment : MonoBehaviour
{
    public PlayerCombat combat;
    public PlayerBow bow;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("ChangeEquipment"))
        {
            combat.enabled = !combat.enabled;
            bow.enabled = !bow.enabled;
        }
    }
}
