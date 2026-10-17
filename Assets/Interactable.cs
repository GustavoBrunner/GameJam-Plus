using Fungus;
using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable{

    public GameObject Object => this.gameObject;

    public float InteractionDistance => 2f;

    [SerializeField] private Flowchart m_Dialogue;

    private void Update(){
        
    }

    public void Interact(){
        m_Dialogue.ExecuteBlock("StartInteraction");
    }

    private void OnDrawGizmos(){
        //Gizmos.DrawSphere(transform.position, InteractionDistance);
    }

    
}
