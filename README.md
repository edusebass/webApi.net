# MIDDLEWARE

Es un aparte de codigo que se ejecuta por ataras y que realiza una funcion especifica

- Cada un o de los request va a pasar por los midlewares

## Inyección de Dependencias

Nos permite utilizar diferentes tipos abstractos y configurar nuestras dependencias utilizando un inyector sin tener que crear un nuevo objeto o una nueva referencia del componente cada vez que lo necesitemos, sino que el inyector se encarga de pasarnos esa dependencia y la podemos utilizar directamente. Configuración del inyector: Para la configuración del inyector tenemos las siguientes opciones:

1. Usando builder.Services.addscop<>(); : De esta manera estamos creando una nueva instancia de la dependencia que estamos usando, pero a nivel de controlador o a nivel de clase, es decir que no importa si estamos inyectando varias veces y en diferentes partes esta dependencia dentro de todo el contexto del controlador o todo el contexto de la clase, se va a inyectar exactamente la misma instancia que se creo para todo ese elemento. (También podemos usar builder.Services.addTrasient)

2. Usando builder.Services.addsingleton : De esta manera estamos creando UNA ÚNICA implementación o instancia de esa dependencia EN TODA LA API (no es recomendable usar singleton porque hacemos que nuestras dependencias se creen en memoria lo que podría causar un problema, además la tendencia es implementar APIS que sean stateless que no manejen ningún tipo de estado sino que con cada request se cree una nueva implementación o instancia de la dependencia configurada.)
