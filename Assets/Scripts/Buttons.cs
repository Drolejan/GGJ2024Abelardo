using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject activar,desactivar;
    public GameObject[] finales;
    public void Quit()
    {
        Application.Quit();
    }
    public void AbrirEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }
    public void Activar()
    {
        activar.SetActive(true);
    }
    public void Desactivar()
    {
        desactivar.SetActive(false);
    }
    public void Gameover(int indice)
    {
        finales[indice].SetActive(true);
    }
}
