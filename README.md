# Fundamentos2
Actividades Técnicas de desarrollo 2D

#######################################

########## Actividad Sprites ##########

#######################################

(Escena 1 - Scripts PlayerController/GroundTrusth/EnemyDistanceCheck)

En esta práctica se han implementado dos animaciones al personaje, "Idle" y "Run". Se aplica Flip a los sprites cuando se cambia de sentido.

![alt tag](SpritesGifs/gif1.gif)

En tiempo de ejecución, la tecla X hace explotar al enemigo cuando se encuentra presente en pantalla.

![alt tag](SpritesGifs/gif2.gif)

Cuando el jugador se aproxima al enemigo desde la zona superior, tocándolo, se genera una animación de explosión antes de destruirlo.

![alt tag](SpritesGifs/gif3.gif)


#######################################

########## Actividad Físicas ##########

#######################################

(Escena 1 - Scripts PlayerController/GroundTruth/DashPlatform/Ascensor)

En esta actividad se prepara una pequeña escena para jugar con los físicas de Unity. En el siguiente gif se pueden encontrar varios ejemplos de físicas, por ejemplo: 

· Una caja estática flotando en el aire,

· una caja kinemática que sube y baja mediante animaciones y que no se puede alterar, 

· o la caja dinámica que cae desde el cielo al activar la palanca.

![alt tag](FisGifs/gif1.gif)

El detalle referente a las distintas configuraciones físicas de Unity se encuentra localizado en el fichero markdown "Físicas"

Usando OnCollision y OnTrigger mostramos mensajes por consola.

![alt tag](FisGifs/gif7.gif)

Referente a la incorporación de elementos físicos en la escena, se han incorporado:

Una barrera estática infranqueable.

![alt tag](FisGifs/gif2.gif)

Una zona en la que los objetos que caen en ella son impulsados hacia delante.

![alt tag](FisGifs/gif3.gif)

Un objeto que es arrastrado por otro a una distancia fija.

![alt tag](FisGifs/gif4.gif)

Un objeto que responde ante colisiones físicas.

![alt tag](FisGifs/gif5.gif)

Utilización de capas para configuración de colisiones entre objetos.

![alt tag](FisGifs/gif6.gif)


##########################################################

########## Actividad de generación de Tile Maps ##########

##########################################################

(Escena 1/Escena 2 - No hay scripts específicos asociados a esta práctica)

En esta práctica se aplican dos paletas:

La primera es una paleta de tiles regulares, con el que se construye el siguiente mapa. El mapa contiene obstáculos y barreras.

![alt tag](PaletasGifs/gif1.gif)

La segunda paleta utiliza tiles isométricos, para los que se han generado zonas elevadas que sirven de obstáculos.

![alt tag](PaletasGifs/gif2.gif)
![alt tag](PaletasGifs/gif3.gif)


###########################################

########## Actividad de Técnicas ##########

###########################################

(Escena 1 - Scripts GameEvent/UnlockerEnter/LiftBarrier/EventSpawnEagle/GamePause/GameOver/HealthManager/Score/LeverAction)

Los eventos se controlan mediante la clase GameEvent. En este gif se puede observar varias instancias donde se utilizan eventos, por ejemplo:

· Inicio de partida mediante evebtos -> despausado de juego y retirada del cartel informativo al pulsar el botón "Aceptar".

· Evento al usar la palanca con la letra "E", dejando caer una caja física.

· Generación de varios comportamientos en base a un único evento subscrito por diferentes clases -> Al recoger la gema se agregan puntos al contador, retira una barrera e invoca a un enemigo

![alt tag](EventosGifs/gif1.gif)

Además, en el siguiente gif se puede aprecias como, con eventos, se controla la vida del personaje (representada arriba a la izquierda) al entrar en contacto con un enemigo.

![alt tag](EventosGifs/gif2.gif)

Por último, el fin de la partida se gestiona mediante eventos, de la misma manera que se controla el inicio. Así, cuando la vida del personaje llega a 0, se pausa la partida, se muestra un emnsaje y se reinicia la partida al pulsar el botón "Aceptar".

![alt tag](EventosGifs/gif3.gif)


###########################################

########## Actividad de Técnicas ##########

###########################################

(Escena 3/Escena 4/Escena 5/Escena 6 - Scripts BoxToFace/Scroll/PCBGLoop/ScrollOnLimit/OnBorderLimit/RandomMovement/Pooler/EnemyDeathWithPool)

Escena con scroll de movimiento de fondo. Aparecen objetos sobre los que tiene que saltar el personaje.

![alt tag](TecGifs/gif1.gif)

Escena donde el scroll se aplica cuando el personaje abandona el fondo.

![alt tag](TecGifs/gif3.gif)

Fondo con efecto parallax. Diferentes elementos del fondo se despalzan a diferentes velocidades en función del movimiento del personaje. las piezas del fondo se desplazan para dar impresión de fondo continuo.

![alt tag](TecGifs/gif2.gif)

Uso de pool de objetos para generar enemigos sobre los que el personaje puede saltar para obtener puntos.

![alt tag](TecGifs/gif4.gif)


########################################################

########## Actividad de controlador de cámara ##########

########################################################

(Escena 7 - Scripts CameraChange/ImpulseOnContact/VibrationOnClick)

En el primer gif se puede apreciar como se utiliza cinemachine para crear 3 cámaras virtuales controladas mediante las teclas "B", "N" y "M":

· Una cámara virtual A que sigue al personaje

· Una cámara B que sigue al áquila con un mayor área de seguimiento

· Una cámara C que sigue tanto al personaje como al águila mediante el uso de target groups de cinemachine

Las cámaras A y C tienen un área de confinamiento que abarca el total de la escena. La cámara B posee un área de confinamiento más limitada.

![alt tag](CamGifs/gif1.gif)

Además, se incorporan elementos a la escena que aplican vibración a las cámaras mediante el sistema de impulsos de cinemachine. hay dos formas de hacer vibrar la cámara:

· Tocando la cámara, que tiene un "impulse source" asociado

· Apretando el click izquierdo del ratón, que activa la condición 

![alt tag](CamGifs/gif2.gif)