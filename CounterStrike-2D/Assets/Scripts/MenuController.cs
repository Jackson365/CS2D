using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void NovoJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void SairDoJogo()
    {
        Application.Quit();
    }

    public void VoltarAoinicio()
    {
        SceneManager.LoadScene("menuInicial");
        Cursor.visible = true;
    }
}
