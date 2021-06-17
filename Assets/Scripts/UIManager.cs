using UnityEngine;

public class UIManager : MonoBehaviour {
    [SerializeField] GameObject deathPanel;
    [SerializeField] GameObject victoryPanel;
    
    public void ToggleDeathPanel() {
        deathPanel.SetActive(!deathPanel.activeSelf);
    }
    
    public void ToggleVictoryPanel() {
        victoryPanel.SetActive(!deathPanel.activeSelf);
    }
}
