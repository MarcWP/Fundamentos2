using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int TotalHealth;
    public HealthBar healthbar;
    public Slider slider;

    //establecemos salud total y nos suscribimos al evento de daño
    void Start()
    {
        GameEvent.current.onTakeHit += substractHealth;
    }

    //En nuestro caso solo hay un enemigo, sin embargo, se puede argumentos para indicar diferentes magnitudes de daño
    private void substractHealth()
    {
        slider.value -= 20;
        //Si nuestra salud cae por debajo de 0, llamamos al evento de muerte
        if (slider.value <= 0)
        {
            //Podríamos gestionar la muerte aquí, pero si separamos dependencias podemos reutilizar el evento de muerte 
            GameEvent.current.death();
        }
    }


}
