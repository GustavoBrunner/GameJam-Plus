using UnityEngine;
using UnityEngine.Events;

public class UiEvents{
    public static UnityEvent<bool> onTurnInteractUi = new();
    public static UnityEvent<bool> onTurnNewInteractFeedback = new();
}
