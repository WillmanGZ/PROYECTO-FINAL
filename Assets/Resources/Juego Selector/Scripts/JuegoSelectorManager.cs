using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JuegoSelectorManager : MonoBehaviour
{   
    public Renderer fondo; //Selecciona un material 3D para fondo
    public AudioSource musica; //Selecciona una fuente de audio, como un archivo .mp3
    public GameObject contenedor; //Objeto donde saldrán los minijuegos
    public Sprite boton_musica_off;//Sprite del boton musica apagado
    public Sprite boton_musica_on;//Sprite del boton musica encendio
    public Image boton_musica;//Selector del objeto boton musica
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Hace que el objeto 3D se mueva 0.02f unidades en el eje X por segundo
       fondo.material.mainTextureOffset = fondo.material.mainTextureOffset + new Vector2(0.02f,0)* Time.deltaTime; 
    }
    public void BotonMusica()//Prende o apaga la musica, cambiando sus sprites entre muted y on
    {
        if (musica !=null)
        {
            if(musica.mute == false)
            {
                boton_musica.sprite = boton_musica_off;
                musica.mute = true;
            } 
            else if(musica.mute == true)
            {
                boton_musica.sprite = boton_musica_on;
                musica.mute = false;
            }
            
        }
    }
    public void botonBack(){
        SceneManager.LoadScene(0);
    }
    public void SelectorHistorias() //Muestra el contenedor en caso de no estar en la escena y muestra los minijuegos de español
    {
        SceneManager.LoadScene(2);
    }

}
