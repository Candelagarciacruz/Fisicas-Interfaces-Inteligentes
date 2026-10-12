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
Los tres objetos son físicos y la esfera tiene fricción ya que a se le ha asignado un `Physics Material` a su componente Collider. Esta propiedad influye en el rozamiento durante el contacto con otras superficies, reduciendo el deslizamiento según el material físico y sus parámetros de fricción (se han mantenido los iniciales): <img width="221" height="116" alt="image" src="https://github.com/user-attachments/assets/84109053-467e-4dc8-b545-e1176c523b08" />
<img width="938" height="546" alt="Situacion7" src="https://github.com/user-attachments/assets/02eeb5e0-a9f7-43a2-a964-80ebe70f2fb3" />

### Situación 8

El plano es cinemático, el cubo es físico y la esfera no es física y tiene activada la opción `Is Trigger` en su `Collider`. La esfera detecta el paso o contacto de otros objetos, pero no actúa como una superficie sólida: el cubo puede atravesarla sin recibir una respuesta física de colisión como se muestra al ejecutar la situación:
<img width="918" height="572" alt="Situacion8" src="https://github.com/user-attachments/assets/be7be939-0b59-498b-9342-d6303c4fdba8" />

Situación 9

### Situación 9
Esta situación es como la anterior pero ahora la esfera sí es física (además de tener activada la opción `Is Trigger`). A diferencia de la situación anterior, la esfera también participa en la simulación física, aunque el trigger sigue permitiendo detectar contactos sin generar una respuesta física de colisión por lo que puede atravesarlos:
- Con la esfera siendo el objeto a mayor altura:
<img width="912" height="534" alt="Situacion9" src="https://github.com/user-attachments/assets/7bbac95c-092b-42fe-be4f-c5778fa951ef" />

- Con el cubo a mayor altura:
<img width="828" height="560" alt="Situacion9 1" src="https://github.com/user-attachments/assets/2e68a4bc-4082-4dff-aced-cc88f74682ad" />

## Movimiento - Físicas
