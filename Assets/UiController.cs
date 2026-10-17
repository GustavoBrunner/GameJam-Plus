using UnityEngine;

public class UiController : MonoBehaviour{
    [SerializeField] private GameObject m_InteractPanel;
    [SerializeField] private GameObject m_InteractFeedback;

    private void Awake(){
        ChangeInteractStatus(false);
    }

    public void ChangeInteractStatus(bool status){
        m_InteractPanel.SetActive(status);
    }

    public void InteractionFeedbackStatus(bool status){
        m_InteractFeedback.SetActive(status);

    }

    private void OnEnable(){
        UiEvents.onTurnInteractUi.AddListener(ChangeInteractStatus);
        UiEvents.onTurnNewInteractFeedback.AddListener(InteractionFeedbackStatus);
    }
}
