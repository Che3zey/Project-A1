using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Called when the button is clicked
    public void Quit()
    {
        Debug.Log("Game is quitting...");

        // If running as a built game
        Application.Quit();

        // If running inside the Unity Editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
