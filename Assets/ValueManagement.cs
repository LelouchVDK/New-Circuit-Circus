using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ValueManagement : MonoBehaviour
{
    public static int voltage = 5;
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void OnSliderChanged(float value)
    {
        voltage = (int)value;
    }

    public void Quitting()
    {
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif

    }
    
}
