generic-kata
============

El objetivo de este ejercicio es practicar los conceptos basicos sobre Genericidad utilizando el lenguaje de programacion C#.

El proceso esta definido por 5 pasos. Para la ejecucion de cada paso se cuentan con 8 minutos aproximadamente. Para avanzar a un paso especifico debe ejecutarse el comando 

```git
git checkout -f step-<#step>
```
Donde el parametro <#step> debe ser sustituido por uno de los pasos especificos (ejemplo: git checkout -f step-0 para ir al paso cero)

---
Los criterios de aceptacion para el paso 1 del ejercicio son los siguientes:
* Debe permitir annadir el numero 2 a la pila
* Debe permitir annadir los numeros 10 y 3 a la pila
* Debe tener una capacidad maxima de elementos
* Debe arrojar error si se agregan mas elementos que la capacidad maxima
* La capacidad minima debe ser cero
* Debe retornar 3 si el 3 fue el ultimo numero adicionado a la pila
* Si se agrega el numero 5 y el numero 3 y se extraer el primer elemento de la pila el proximo elemento tiene que ser el numero 5
* Si se extrae un elemento de una pila vacia debe arrojar un error

---
Los criterios de aceptacion para el paso 2 del ejercicio son los siguientes:

* Debe permitir annadir la cadena "Hola" a la pila
* Debe permitir annadir las cadenas "Hola" y "Mundo" a la pila
* Debe tener una capacidad maxima de elementos
* Debe arrojar error si se agregan mas elementos que la capacidad maxima
* La capacidad minima debe ser cero
* Debe retornar "Hola" si "Hola" fue la ultima cadena adicionada a la pila
* Si se agrega la cadena "Hola" y "Mundo" y se extraer el primer elemento de la pila el proximo elemento tiene que ser la cadena "Hola"
* Si se extrae un elemento de una pila vacia debe arrojar un error

---
Lo mismo para un objeto Car