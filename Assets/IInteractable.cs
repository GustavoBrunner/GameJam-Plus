using UnityEngine;

public interface IInteractable{
    public GameObject Object { get; }
    
    public float InteractionDistance { get; }
    public void Interact();
}
