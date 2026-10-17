using UnityEngine;

public class GameController : MonoBehaviour{

    [SerializeField]
    private UiController UiController;

    private int m_newInteractionCount;
    public int NewInteractionCount {  
        get => m_newInteractionCount; 

        private set{
            m_newInteractionCount = value;
            if(m_newInteractionCount > 0){
                if (UiController)
                    UiEvents.onTurnNewInteractFeedback.Invoke(true);
            }
            else
                UiEvents.onTurnNewInteractFeedback.Invoke(false);
        }
    }

    void Start(){
        UiController = FindFirstObjectByType<UiController>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void AddNewInteraction(int newInteraction) { 
        NewInteractionCount += newInteraction;
        if (m_newInteractionCount < 0)
            m_newInteractionCount = 0;

        Debug.Log(m_newInteractionCount);

    }
}
