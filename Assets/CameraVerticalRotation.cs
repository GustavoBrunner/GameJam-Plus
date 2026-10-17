using UnityEngine;

public class CameraVerticalRotation : MonoBehaviour{
    [SerializeField] private float m_MouseYPos;
    [SerializeField] private float m_Sensitivity;
    [SerializeField] private float m_Rotation;

    [SerializeField] private Vector3 m_LastMousePosition;

    private void Start(){
        m_LastMousePosition = Input.mousePosition;
    }

    void Update(){
        if (GetComponentInParent<InteractionSystem>().IsInteraction)
            return;
        float mouseDeltaY = Input.mousePosition.y - m_LastMousePosition.y;

        m_Rotation -= mouseDeltaY * m_Sensitivity;
        m_Rotation = Mathf.Clamp(m_Rotation, -60f, 60f);

        transform.localRotation = Quaternion.Euler(m_Rotation, 0f, 0f);

        m_LastMousePosition = Input.mousePosition;
    }
}
