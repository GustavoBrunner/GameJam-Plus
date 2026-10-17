using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour{
    [UnityEngine.Range(0f, 10f)]
    [SerializeField] private float m_RayDistance;

    [SerializeField] private Transform m_CamPosition;

    public List<IInteractable> m_SceneInteractables = new();

    public bool IsInteraction { get; private set; } = false;

    private void Awake(){
        m_SceneInteractables.AddRange(FindObjectsByType<Interactable>(FindObjectsSortMode.None) );    
        Debug.Log(m_SceneInteractables.Count);
    }
    private void Update(){
        InteractionRayCast();
        
    }

    private void InteractionRayCast(){
        RaycastHit hit;
        if (Physics.Raycast(m_CamPosition.position, m_CamPosition.forward, out hit, m_RayDistance)){
            if (hit.collider.TryGetComponent(out IInteractable interactable)){
                if (Input.GetKeyDown(KeyCode.E)){
                    interactable?.Interact();
                    IsInteraction = true;
                }
            }
        }
    }

    public void SetInteractionFalse(){
        IsInteraction = false;
    }
    

}
