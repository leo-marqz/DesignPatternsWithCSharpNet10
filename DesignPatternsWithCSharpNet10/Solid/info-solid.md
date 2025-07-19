🔹 S — Single Responsibility Principle (SRP)
"Una clase debe tener una única razón para cambiar."
Cada módulo o clase debe encargarse de una sola responsabilidad o función del negocio. Esto reduce el acoplamiento y facilita el mantenimiento.

🔹 O — Open/Closed Principle (OCP)
"El software debe estar abierto para extensión, pero cerrado para modificación."
Puedes agregar nuevas funcionalidades a una clase sin modificar su código existente, utilizando herencia o composición. Favorece la estabilidad y evita romper funcionalidades previas.

🔹 L — Liskov Substitution Principle (LSP)
"Las clases derivadas deben poder reemplazar a sus clases base sin alterar el comportamiento del programa."
Una subclase debe comportarse como su superclase. Si una función espera una clase base, también debe poder aceptar cualquier subclase sin errores o resultados inesperados.

🔹 I — Interface Segregation Principle (ISP)
"Los clientes no deben estar obligados a depender de interfaces que no utilizan."
Es mejor crear interfaces específicas y pequeñas que grandes y genéricas. Esto evita que las clases implementen métodos innecesarios y promueve el diseño limpio.

🔹 D — Dependency Inversion Principle (DIP)
"Las clases deben depender de abstracciones, no de concreciones."
En lugar de acoplar directamente clases entre sí, se debe depender de interfaces o abstracciones. Esto facilita el testing, el desacoplamiento y la inyección de dependencias.