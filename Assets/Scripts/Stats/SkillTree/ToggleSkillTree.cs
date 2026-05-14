using UnityEngine;

public class ToggleSkillTree : MonoBehaviour
{
    public CanvasGroup statsCanvas;
    private bool skillTreeOpen = false;

    private void Start()
    {
        statsCanvas.alpha = skillTreeOpen ? 1 : 0;
        statsCanvas.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("ToggleSkillTree"))
        {
            skillTreeOpen = !skillTreeOpen;
            Time.timeScale = statsCanvas.alpha = skillTreeOpen ? 1 : 0;
            statsCanvas.blocksRaycasts = skillTreeOpen ? true : false;
        }
    }
}
