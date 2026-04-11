using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void OnPersistClick() {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnReturnClick() {
        SceneManager.LoadScene("Start");
    }

    void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
