using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBoton : MonoBehaviour

{

    public AudioSource Fuente,cancion;
    public AudioClip Clip;

    // Start is called before the first frame update
    void Start()
    {
        Fuente.clip = Clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reproducir() 
    {
        Fuente.Play();
    }

    public void Parar()
    {
        cancion.Stop();
    }
}
