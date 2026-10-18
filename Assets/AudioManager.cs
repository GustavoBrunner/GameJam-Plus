using UnityEngine;

public class AudioManager : MonoBehaviour{

    [SerializeField] AudioClip m_BarMusic;
    [SerializeField] AudioClip m_RoomsMusic;
    [SerializeField] AudioSource m_Music;
    [SerializeField] AudioClip m_MenuMusic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        m_Music.clip = m_BarMusic;
        m_Music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
