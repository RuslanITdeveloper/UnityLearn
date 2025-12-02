using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
