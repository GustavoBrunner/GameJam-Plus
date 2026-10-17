using UnityEngine;

public class UiController : MonoBehaviour{
    [SerializeField] private GameObject m_InteractPanel;

    private void Awake(){
        ChangeInteractStatus(false);
    }

    public void ChangeInteractStatus(bool status){
        m_InteractPanel.SetActive(status);
    }

    private void OnEnable(){
        UiEvents.onTurnInteractUi.AddListener(ChangeInteractStatus);
    }
}
