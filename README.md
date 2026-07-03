# Jump & Dodge

[Español](#español) | [English](#english)

---

## Español

Un juego de estilo *endless runner* desarrollado en Unity donde los jugadores ponen a prueba sus reflejos controlando a un personaje que corre por una ciudad, esquivando obstáculos para sobrevivir el mayor tiempo posible.

### 🚀 Mecánicas y Características Implementadas
* **Mecánica de Salto Precisa:** Movimiento vertical basado en físicas utilizando `Rigidbody.AddForce` al presionar la barra espaciadora.
* **Detección de Suelo:** Implementación de mecánicas de aterrizaje seguro mediante `OnCollisionEnter` para evitar saltos infinitos en el aire y asegurar una jugabilidad estable.
* **Generación Dinámica de Obstáculos:** Un `SpawnManager` centralizado gestiona intervalos de tiempo aleatorios para instanciar barreras en la calle, manteniendo el juego impredecible.
* **Fondo Infinito (Scrolling Background):** Script de reposicionamiento automático que genera un bucle continuo en el fondo de la ciudad para simular movimiento constante.
* **Efectos Inmersivos:** Sistemas de partículas visuales para el polvo al correr y explosiones al chocar, junto con clips de audio personalizados para los saltos y el estado de Game Over.

### 🛠️ Tecnologías Utilizadas
* **Motor:** Unity 6 LTS
* **Lenguaje:** C#
* **Conceptos clave:** Físicas de Rigidbody, interpolación de colisiones, destrucción procedimental de objetos, bucles de objetos e integración de partículas/audio.

### 🕹️ Cómo Jugar
1. Presiona la **Barra Espaciadora** para saltar los obstáculos que aparecen.
2. El tiempo lo es todo: chocar contra cualquier barrera provoca un Game Over inmediato.

---

## English

An endless runner game developed in Unity where players test their reflexes by controlling a character running through a stylized city environment, avoiding obstacles to survive as long as possible.

### 🚀 Features & Mechanics
* **Precise Jump Mechanics:** Physics-based vertical movement using `Rigidbody.AddForce` triggered by the Spacebar.
* **Ground Detection:** Implemented safe landing mechanics via `OnCollisionEnter` to prevent infinite air-jumping and ensure stable gameplay.
* **Dynamic Obstacle Spawning:** A centralized `SpawnManager` handles random timing intervals to instantiate street barriers, keeping the gameplay unpredictable.
* **Scrolling Background:** Automatic repositioning script that seamlessly loops the city backdrop texture to simulate non-stop forward momentum.
* **Immersive Effects:** Visual particle systems for running dust and crash explosions, paired with custom audio clips for jumps and game-over states.

### 🛠️ Technologies Used
* **Engine:** Unity 6 LTS
* **Language:** C#
* **Core Concepts:** Rigidbody physics, collision interpolation, procedural object destruction, object looping, and particle/audio integration.

### 🕹️ How to Play
1. Press the **Spacebar** to jump over the oncoming barriers.
2. Timing is key—crashing into any obstacle results in an immediate Game Over.
