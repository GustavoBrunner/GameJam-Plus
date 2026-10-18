using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour{
    [SerializeField] private GameObject m_InteractPanel;
    [SerializeField] private Image m_InteractFeedback;


    [SerializeField] private Sprite[] m_InteractFeedbackSprite;
    private void Awake(){
        ChangeInteractStatus(false);
    }

    public void ChangeInteractStatus(bool status){
        m_InteractPanel.SetActive(status);
    }

    public void InteractionFeedbackStatus(bool status){
        if (status)
            m_InteractFeedback.sprite = m_InteractFeedbackSprite[0];
        else
            m_InteractFeedback.sprite = m_InteractFeedbackSprite[1];

    }

    private void OnEnable(){
        UiEvents.onTurnInteractUi.AddListener(ChangeInteractStatus);
        UiEvents.onTurnNewInteractFeedback.AddListener(InteractionFeedbackStatus);
    }
}
