using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InicioManager : MonoBehaviour
{
    public GameObject canvas;
    public Renderer fondo; //Selecciona un material 3D para fondo
    public AudioSource Musica;
    
    
    // Start is called before the first frame update
    void Start()
    {
      AudioListener.volume = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
      int mute = PlayerPrefs.GetInt("musicaOn", 1);
      if (mute == 0)
      {
        Musica.mute = true;
      }
    }

    // Update is called once per frame
    void Update()
    {
        //Hace que el objeto 3D se mueva 0.02f unidades en el eje X por segundo
        fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.02f,0)* Time.deltaTime;
    }

    public void BotonJugar() //Nos dirije a la escena JuegoSelector
    {
        SceneManager.LoadScene(1);
    }

    public void BotonCreditos() //Muestra los creditos
    {
       SceneManager.LoadScene(2); 
    }

    public void BotonSalir() //Hace que se cierre la aplicacion. (Dentro del editor no se ejecuta el QUIT, solamente cuando el juego esté corriendo)
    {
        Application.Quit();
    }

    public void BotonConfiguraciones()
    {
        SceneManager.LoadScene(9);
    }
    
}
