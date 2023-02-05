using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioJuego : MonoBehaviour
{
    private void OnMouseDown()
    {
        ChangeScene();   
    }

    void ChangeScene()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }
}

