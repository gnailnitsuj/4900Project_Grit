using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void OnStartClick() {
        SceneManager.LoadScene("SampleScene");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void OnQuitClick() {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
        #endif
        Application.Quit();
    }
}
