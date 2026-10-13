# Fisicas-Interfaces-Inteligentes

## Experimentando con la física desde el editor

### Situación 1
El cubo  al ser un objeto físico tiene un `Rigidbody`, por lo que la gravedad actúa sobre él, mientras que el plano y la esfera solo tienen `Collider`. 
- Si el cubo se ubica con y= 50 como se indica inicialmente no ocurren cambios:
<img width="596" height="286" alt="situacion1" src="https://github.com/user-attachments/assets/7d97d7df-b567-4540-bcc0-2a694152ac27" />

- Mientras que si se encuentra a mayor altura el cubo cae hasta entrar en contacto con el plano o la esfera, que pueden detectar colisiones, pero no responden físicamente a ellas al no tener `Rigidbody`:
<img width="750" height="566" alt="Situacion1" src="https://github.com/user-attachments/assets/af836679-f086-4b2a-8c67-48d3635ce9d9" />

### Situación 2
Ahora tanto el cubo como la esfera tienen `Rigidbody`, por lo que ambos responden a la gravedad y a las colisiones. A diferencia de la situación anterior, la esfera también puede moverse como consecuencia de los impactos con el cubo.
- Manteniendo el cubo con y = 50 solo cae la esfera:
<img width="902" height="574" alt="Situacion2 1" src="https://github.com/user-attachments/assets/3a92678d-e258-47ec-be2d-f53b4f039da4" />

- Si el cubo se encuentra a mayor altura ambos objetos caen y responden físicamente a las colisiones:
<img width="1110" height="586" alt="Situacion2" src="https://github.com/user-attachments/assets/e7a2ffc1-3950-40dc-abd5-69ec5d67f552" />
 
### Situación 3
El cubo es un objeto físico y la esfera tiene un `Rigidbody` con la opción `Is Kinematic` activada. La esfera no responde a la gravedad ni a las fuerzas, pero puede interactuar con el cubo, que sí reacciona físicamente a la colisión, como se puede observar si cae desde alto:
<img width="866" height="582" alt="Situacion3" src="https://github.com/user-attachments/assets/559a4f6f-717f-4d2c-b3be-5bab4df651d5" />

### Situación 4
Los tres objetos tienen `Rigidbody`, incluido el plano, que ahora es un objeto físico. Al estar sometido a la simulación física, el plano puede moverse o caer bajo la acción de la gravedad, en lugar de permanecer fijo como en las situaciones anteriores. 
Se puede observar a continuación como el plano cae al igual que la esfera y el cubo:
<img width="832" height="534" alt="Situacion4" src="https://github.com/user-attachments/assets/e549e443-c689-4294-8aaa-4ba0d0b95ae4" />

### Situación 5
El plano es cinemático, tiene la opción `Is Kinematic` activada, y permanece bajo control directo, mientras que el cubo y la esfera son objetos físicos. La esfera tiene diez veces más masa que el cubo (masa esfera = 10 y masa cubo = 1), por lo que, ante una colisión, su movimiento suele verse menos afectado que el del cubo.
Aquí se puede observar como ahora la colisión tiene mayor efecto en el cubo que en la esfera:
<img width="984" height="568" alt="Situacion5" src="https://github.com/user-attachments/assets/b95447c8-201c-4072-bd87-cc8809cb8f58" />

### Situación 6
Esta situación es similar a la anterior, pero la esfera tiene cien veces más masa que el cubo (masa esfera = 100 y masa cubo = 1). La diferencia de masa es mayor, por lo que la esfera suele experimentar un cambio de movimiento menor y el cubo resulta más afectado por el impacto:
<img width="922" height="576" alt="Situacion6 (1)" src="https://github.com/user-attachments/assets/105c6e08-bd5c-436b-a201-e9f7c7d2aa87" />

### Situación 7
Los tres objetos son físicos y la esfera tiene fricción ya que a se le ha asignado un `Physics Material` a su componente Collider. Esta propiedad influye en el rozamiento durante el contacto con otras superficies, reduciendo el deslizamiento según el material físico y sus parámetros de fricción (se han mantenido los iniciales).
<img width="221" height="116" alt="image" src="https://github.com/user-attachments/assets/84109053-467e-4dc8-b545-e1176c523b08" />
- Con plano físico:
<img width="938" height="546" alt="Situacion7" src="https://github.com/user-attachments/assets/02eeb5e0-a9f7-43a2-a964-80ebe70f2fb3" />

-Con plano cinemático:
<img width="960" height="564" alt="Situacion7 1" src="https://github.com/user-attachments/assets/730562f3-4931-484e-b1e7-b815168a0458" />

### Situación 8
El plano es cinemático, el cubo es físico y la esfera no es física y tiene activada la opción `Is Trigger` en su `Collider`. La esfera detecta el paso o contacto de otros objetos, pero no actúa como una superficie sólida: el cubo puede atravesarla sin recibir una respuesta física de colisión como se muestra al ejecutar la situación:
<img width="918" height="572" alt="Situacion8" src="https://github.com/user-attachments/assets/be7be939-0b59-498b-9342-d6303c4fdba8" />

### Situación 9
Esta situación es como la anterior pero ahora la esfera sí es física (además de tener activada la opción `Is Trigger`). A diferencia de la situación anterior, la esfera también participa en la simulación física, aunque el trigger sigue permitiendo detectar contactos sin generar una respuesta física de colisión por lo que puede atravesarlos:
- Con la esfera siendo el objeto a mayor altura:
<img width="912" height="534" alt="Situacion9" src="https://github.com/user-attachments/assets/7bbac95c-092b-42fe-be4f-c5778fa951ef" />

- Con el cubo a mayor altura:
<img width="828" height="560" alt="Situacion9 1" src="https://github.com/user-attachments/assets/2e68a4bc-4082-4dff-aced-cc88f74682ad" />

## Movimiento - Físicas

## Ejercicio 1
Se ha creado una cápsula como personaje y se le han añadido los componentes `Rigidbody` y `Capsule Collider` para controlar su movimiento. El movimiento se define en el script asociado a la cápsula *"movementCapsule.cs"*, se realiza con las teclas WASD o las flechas, obteniendo la entrada mediante `Input.GetAxis()`. Además, se utiliza `Rigidbody.MovePosition()` en `FixedUpdate()` para mover al personaje durante las actualizaciones de física, ajustando el desplazamiento con `Time.fixedDeltaTime`.
A continuación se observa su ejecución:
<img width="1626" height="844" alt="Ex1" src="https://github.com/user-attachments/assets/50e934ed-59d1-4c97-ac4a-0b2a476a8d1e" />

## Ejercicio 2
Se han elaborado varias (3) esferas con `Rigidbody` dinámico para detectar las colisiones entre los objetos. Mediante `OnCollisionEnter()` se muestra en la consola el nombre del objeto con el que se produce la colisión y se cambia su color utilizando valores RGB aleatorios. De esta forma, se puede observar visualmente cuándo se produce un contacto físico:
<img width="1892" height="938" alt="Ex2" src="https://github.com/user-attachments/assets/2909f088-ce89-4ec6-8096-1c920d8cbdd2" />

## Ejercicio 3
Se han hecho dos zonas con `Is Trigger` activado para detectar la entrada y salida del personaje sin bloquear su movimiento. La primera cambia su color al entrar y lo restaura al salir mediante `OnTriggerEnter()` y `OnTriggerExit()`. La segunda aumenta la variable `damage` (daño) en 1 punto cada vez que el personaje entra en ella, mostrando el valor acumulado en la consola. Se puede ver aquí su ejecución:
<img width="1904" height="878" alt="Ex3" src="https://github.com/user-attachments/assets/e83a9734-6a4f-4256-b665-8b354d28c269" />

## Ejercicio 4
Se han creado las capas `Jugador`, `Enemigos` y `Recolectables`, asignándolas a sus respectivos objetos (cubos más altos -> enemigos, otros cubos -> recolectables y cápsula -> jugador). En **Edit -> Project Settings > Physics** se ha configurado la `Layer Collision Matrix` para controlar qué capas pueden interactuar: 
<img width="238" height="235" alt="image" src="https://github.com/user-attachments/assets/604cea0d-9784-48e0-a8bf-2567803a6028" />
Los enemigos colisionan con el jugador, mientras que los recolectables utilizan colliders con `Is Trigger` activado para detectar el contacto sin bloquear el movimiento. Al ejecutarlo se puede ver:
<img width="1902" height="922" alt="Ex4" src="https://github.com/user-attachments/assets/da4ad2e9-04aa-42e2-ba57-7f0bed2f61e5" />

## Ejercicio 5
Se han creado tres cubos con `Rigidbody` y distintos `Physic Materials`: resbaladizo (el cubo más a la izquierda), rugoso (el cubo más a la derecha) y de rebote alto (el del medio). Al pulsar la tecla X, se aplica una fuerza mediante `AddForce()` con `ForceMode.Impulse`. Se observan las distintas reacciones de los cubos al pulsar la tecla X, con el mismo valor fuerza = 3, según la fricción y el rebote configurados en sus materiales físicos:
<img width="1906" height="858" alt="Ex5" src="https://github.com/user-attachments/assets/fb8322b7-dbaf-4047-b9c8-afd40f73aec1" />

<img width="221" height="134" alt="image" src="https://github.com/user-attachments/assets/c67f8b64-ce4e-48e2-b0b1-10d5162021a3" />
<img width="222" height="137" alt="Captura de pantalla 2026-10-13 042908" src="https://github.com/user-attachments/assets/ca4bc0d7-0a48-4d3a-84ca-60d08fc3f0df" />
<img width="223" height="134" alt="image" src="https://github.com/user-attachments/assets/caaf7791-979a-4115-826b-696f8ba95ac9" />

## Ejercicio 6
La escena contiene una esfera, un cubo y un cilindro, todos con `Collider` pero sin `Rigidbody`, tal como indica el enunciado. Sin embargo, los `Collider` por sí solos no permiten que los objetos se muevan mediante la simulación física de Unity, ya que no tienen un `Rigidbody` que gestione su movimiento dinámico. Aunque Unity puede detectar colisiones entre colliders estáticos y otros objetos, estos tres objetos no pueden interactuar como cuerpos físicos dinámicos si ninguno tiene `Rigidbody`.
Por este motivo, no se puede implementar el comportamiento completo mediante colisiones físicas tal como está planteado. 

*Candela García Cruz*
