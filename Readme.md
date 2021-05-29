# Summary
Este repositorio es una guia para conocer y dominar el manejo de estructuras de datos y algoritmos básicos que debes manejar como informático. Aquí encontrarás ejemplos de uso de cada uno de los algoritmos y estructuras, todos los ejercicios los he utilizado a modo de práctica, así que sientete libre de sugerir cambios en los algoritmos o conceptos. 

Happy codding!

# Table of content
1. [Estructuras de datos](#estructuras)
2. [Principales estructuras de datos](#principalesestructuras)
3. [Notacion asisntótica](#notacionasintotica)


# Estructuras de datos <a name="estructuras"></a>
Las estructuras de datos no son mas que mecanismos que nos permiten almacenar y manipular información.

## Principales estructuras de datos <a name="principalesestructuras"></a>

1.  Vector (Array): Los datos se almacenan de forma contigua es decir se reserva espacio en memoria ram que permite almacenar los datos uno al lado del otro: [0][1][2][3][4]

2.  Lista enlazada (Linked List): A diferencia del array los elementos no están contiguos en memoria, sino repartidos en esta, para esto se hace uso de punteros que apunta a la siguiente posición en memoria del siguiente elemento, en el caso de las listas enlazadas dobles agregamos dos punteros, uno hacia el anterior y otro hacia el siguiente.

> La inserción es menos costosa en la lista, pero la búsqueda es mucho mas costosa debido a que para ubicar un elemento en el caso del array vamos al indice y lo tenemos, pero en el caso de la lista debemos recorrer punteros desde el principio.

3.  Tablas de hash (HASH Tables): Es una estructura de datos que almacena la información en pares y valores o un modelo key-pair la clave indica a que posición en memoria va el valor. Para convertir lo antes mencionado en un indice se inplementa un algoritmo conocido como función de hash, la función de hash. Para este ejemplo las búsquedas son constantes al igual que las inserciones.

4.  Pilas (LIFO)
5.  Colas (FIFO) 

> En escencia pilas y colas son casi identicas y su implementación muy parecida a la de los array, tiene aplicación directa en algoritmos de grafos.

6.  Grafos / Árboles: Son estructuras de datos cuya característica principal el la representación de relaciones entre entidades utilizando una notación de vértices y aristas. 

> Todos los arboles son grafos pero no todos los grafos son árboles, los árboles son grafos en los que para cada par de nodo solo existe un camino.

7.  Heaps: son árboles binarios (un tipo de arbol/grafo) completos, existen dos tipos (mínimos y máximos), basicamente la diferencia entre los tipos la da si el nodo padre es mayor (en peso) a todos sus hijos. Su uso principal son las colas de prioridad, cuando debemos ordenar ciertos elementos en función de cierto valor.

# Notacion asisntótica <a name="notacionasintotica"></a>
Basicamente nos dice a que medida aumenta el tiempo o el espacio a medida que incrementa la entrada de un algoritmo.