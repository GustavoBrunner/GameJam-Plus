using Fungus;
using UnityEngine;

public enum InteractableType{
    LOOKAT,
    FIXED
}

public class Interactable : MonoBehaviour, IInteractable{
    [SerializeField] private InteractableType m_Type;

    public GameObject Object => this.gameObject;

    public float InteractionDistance => 2f;

    [SerializeField] private Flowchart m_Dialogue;

    [SerializeField] private Transform m_PlayerTf;

    private void Start(){
        m_PlayerTf = FindFirstObjectByType<PlayerController>().transform;
    }
    private void Update(){
        if (m_Type == InteractableType.FIXED)
            return;
        transform.LookAt(m_PlayerTf);
    }

    public void Interact(){
        m_Dialogue.ExecuteBlock("StartInteraction");
    }

    private void OnDrawGizmos(){
        //Gizmos.DrawSphere(transform.position, InteractionDistance);
    }

    
}
