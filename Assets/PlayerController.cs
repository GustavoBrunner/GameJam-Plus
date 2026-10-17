using UnityEngine;

public class PlayerController : MonoBehaviour{
    [SerializeField] private Vector3 m_Direction;
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_XInput;
    [SerializeField] private float m_YInput;


    [SerializeField] private float m_MouseInput;
    [SerializeField] private float m_MouseSensitivity;



    private void Update(){
        if (GetComponent<InteractionSystem>().IsInteraction)
            return;
        Movement();
        CameraRotation();
    }

    private void Movement(){
        m_XInput = Input.GetAxisRaw("Horizontal");
        m_YInput = Input.GetAxisRaw("Vertical");
        m_Direction = new Vector3(m_XInput, 0f, m_YInput);

        transform.Translate(m_Direction.normalized * m_Speed * Time.deltaTime);
    }
    private void CameraRotation(){
        
        m_MouseInput = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up * m_MouseInput * m_MouseSensitivity);
    }

    private void OnTriggerEnter(Collider other){
        if (other.TryGetComponent<Interactable>(out _)){
            UiEvents.onTurnInteractUi.Invoke(true);
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.TryGetComponent<Interactable>(out _)){
            UiEvents.onTurnInteractUi.Invoke(false);
        }
    }

}
