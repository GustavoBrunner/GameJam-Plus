using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  public void playGame()
    {
        SceneManager.LoadScene("arvinho");
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Additive);
    }
}
