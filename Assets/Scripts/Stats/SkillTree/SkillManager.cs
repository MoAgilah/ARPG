using UnityEngine;

public class SkillManager : MonoBehaviour
{
    private void OnEnable()
    {
        SkillSlot.OnAbilityPointSpent += HandleAbilityPointsSpent;
    }

    private void OnDisable()
    {
        SkillSlot.OnAbilityPointSpent -= HandleAbilityPointsSpent;
    }

    private void HandleAbilityPointsSpent(SkillSlot slot)
    {
        string skillName = slot.skillSO.skillName;

        switch (skillName)
        {
            case "MaxHealthBoost":
                StatsManager.instance.UpdateMaxHealth(1);
                break;

            default:
                Debug.LogWarning("Unknown Skill: " + skillName);
                break;
        }
    }
}
