using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoInicio : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadSceneAsync("Inicio");
    }
}
