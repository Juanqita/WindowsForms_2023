# 🖥️ Programación en Tiempo Real - Proyectos en C#

Este repositorio contiene todas las actividades desarrolladas durante el curso de **Programación en Tiempo Real**, implementadas en **C# con Windows Forms**.  
Cada proyecto aborda distintos conceptos de validación, simulación, gráficos, manejo de archivos y lógica de programación.

---

## 📌 Proyectos incluidos

### 🔹 Aplicaciones de práctica
- **Estación Meteorológica** → Simulación de registro de variables ambientales.  
- **Explorador de Frases** → Manipulación de cadenas de texto y operaciones sobre frases.  
- **Tabla de Multiplicar** → Generación de tablas de multiplicar dinámicas en un `DataGrid`.  
- **Tres en Línea (Tic-Tac-Toe)** → Juego clásico con validación de ganador y empate.  
- **Aproximación Exponencial (Serie de Taylor)** → Cálculo numérico de `e^x` usando series de Taylor.  
- **Damas Chinas** → Juego lógico con interfaz interactiva.  
- **Invertir Número de 2 cifras** → Ejercicio de aritmética básica y validación de entrada.  
- **Movimiento Uniformemente Acelerado (MUA)** → Cálculo de variables físicas, listas de evolución temporal y validación de decimales.  
- **Movimiento Uniformemente Acelerado (versión mejorada)** → Implementación extendida con `TabControl` y control de decimales.  
- **Reloj** → Reloj digital en tiempo real.  
- **Valida Claves** → Validación de contraseñas bajo reglas específicas.  
- **Valida Intentos Claves** → Validación de contraseñas con límite de intentos.  
- **Histograma (básico)** → Construcción de histogramas a partir de datos ingresados.  
- **Histograma de Probabilidad** → Versión extendida con definición de intervalos y estadísticas descriptivas (mínimo, máximo, promedio).  

---

## 🎯 Proyecto Final - Osciloscopio en C#

### 🔐 Seguridad
- Sistema de usuarios (archivo con **usuario, contraseña, rol**).  
- **Administrador**: acceso completo y creación de usuarios nuevos.  
- **Invitado**: acceso limitado (sin historial de archivos).  
- Formulario de **Login** con validación de credenciales.  

### ⚙️ Funcionalidad principal
- Encendido/Apagado de la adquisición de señales.  
- Selección de canales (1, 2 o ambos).  
- Configuración de puerto y tiempo de muestreo (simulado en esta versión).  
- Identificación de sensor conocido o lectura de voltaje directo.  
- Escala vertical modificable (V/div).  
- Guardado automático de archivos con consecutivo (tiempo, voltaje, sensor).  
- Visualización de la amplitud máxima y su tiempo.  
- Alertas: mensaje, sonido y encendido de LED (simulado) cuando la señal supera un umbral definido.  
- Historial de archivos con opción de recargar señales previas.  
- Cálculo de promedio de la señal en tiempo real y desde archivos guardados.  

> ⚠️ Debido a problemas con la conexión de sensores reales, las señales fueron **simuladas mediante números aleatorios** en un rango definido para cada variable (ej. temperatura, humedad, voltaje).  

---

## 📂 Estructura del repositorio
📦 Project_PTR
┣ 📂 Estacion_Meteorologica
┣ 📂 ExploradorDeFrases
┣ 📂 Histogramaprobabilidad
┣ 📂 TablasDeMultiplicar
┣ 📂 TresEnLinea
┣ 📂 AproximacionExponencialTaylor
┣ 📂 DamasChinas
┣ 📂 Histograma
┣ 📂 InvertirNumero2Cifras
┣ 📂 MovimientoAcelerado
┣ 📂 MovimientoAceleradoM
┣ 📂 Reloj
┣ 📂 ValidaClaves
┣ 📂 ValidaIntentosClaves
┣ 📂 OsciloscopioFinal
┣ README.md

## 🚀 Ejecución
1. Clonar el repositorio:  
   ```bash
   git clone https://github.com/<tu-usuario>/Project_PTR.git
2. Abrir la solución en Visual Studio.
3. Seleccionar y ejecutar el proyecto deseado.

🛠️ Tecnologías utilizadas
- C# .NET (Windows Forms)
- Chart Control para visualización gráfica
- Manejo de archivos para persistencia de datos
- Timers y simulaciones en tiempo real

📖 Documentación
- Código comentado y estructurado con funciones específicas.
- Nombres de variables y controles claros.
- Validación de caracteres y control de excepciones implementados en todas las aplicaciones.

👤 Autor
Desarrollado por Juan Camilo Peláez como parte del curso de Programación en Tiempo Real.
