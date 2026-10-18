using UnityEngine;

public class GameController : MonoBehaviour{

    private int m_newInteractionCount;
    public int NewInteractionCount {  
        get => m_newInteractionCount; 

        private set{
            m_newInteractionCount = value;
            if(m_newInteractionCount > 0)
                UiEvents.onTurnNewInteractFeedback.Invoke(true);
            else
                UiEvents.onTurnNewInteractFeedback.Invoke(false);
        }
    }

    void Start(){
        
    }

    public void AddNewInteraction(int newInteraction) { 
        NewInteractionCount += newInteraction;
        if (m_newInteractionCount < 0)
            m_newInteractionCount = 0;

        Debug.Log(m_newInteractionCount);

    }
}
