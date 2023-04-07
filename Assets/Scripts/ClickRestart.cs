using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickRestart : MonoBehaviour
{
    // Start is called before the first frame update

    void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("r")))
        {
            SceneManager.LoadScene("Playground");
        }
    }
}
