En esta carpeta encontrarán el código de una pequeña aplicación que simula el comportamiento de una epidemia transmitiéndose en una población.

Existe sólo un tipo de entidad, llamada “Person”. La simulación inicia con 5000 personas, una de las cuales está infectada.
Las personas se mueven de forma aleatoria y se grafican de color azul. Las personas infectadas se grafican de color rojo.
Si una persona infectada entra en contacto con una persona sana, esta última pasa a estar infectada.
Si no existen personas sanas, la simulación se reinicia.

Esta implementación está construida de forma intencionalmente ineficiente. Pueden modificar cualquier parte del código siempre y cuando mantengan la misma funcionalidad.

Consignas
1. Realizar mediciones de performance que permitan diagnosticar el problema.
2. Escribir qué problemas encontró en la simulación en función de las mediciones.
3. Proponer una solución al problema encontrado, describirla en sus palabras con el mayor detalle posible.
4. Implementar la solución planteada haciendo los cambios en el código que sean necesarios.
5. Validar la implementación realizando nuevas mediciones. ¿Se resolvió el problema? En caso negativo, ¿qué otras soluciones alternativas se le ocurren?