using UnityEngine.SceneManagement;
using UnityEngine;

public class Event : MonoBehaviour
{
    // Start is called before the first frame update
    public void Startknopf()
    {
        SceneManager.LoadScene("Level1");

    }

    public void SchließenButton()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }


}












