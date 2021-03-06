# Design Pattern Study
Study of design pattern implementations.

### Structural Design Patterns ###

- [X] Adapter
    > Propósito: O Adapter é um padrão de projeto estrutural que permite objetos com interfaces incompatíveis colaborarem entre si.
    
    >Exemplos de uso: O padrão Adapter é bastante comum no código C#. É frequentemente usado em sistemas baseados em algum    código legado. Nesses casos, os adaptadores criam código legado com classes modernas.

    >Identificação: O adapter é reconhecível por um construtor que utiliza uma instância de tipo abstrato/interface diferente. Quando o adaptador recebe uma chamada para qualquer um de seus métodos, ele converte parâmetros para o formato apropriado e direciona a chamada para um ou vários métodos do objeto envolvido.
    
    >Referencia: https://refactoring.guru/design-patterns/adapter/csharp/example
    
- [X] Bridge
    >Propósito: Padrão de projeto estrutural que permite que você divida a aplicação entre Abstração e Implementação, podendo assim ser desenvolvidas de forma separadas.

    >Exemplos de Uso: Ao invés de vc ter uma composição com uma relação concreta você pode ter uma relação com baixo acoplamento por via de uma abstração, assim podendo ser estendida como no exemplo implementado, respeitando assim Open Closed Principle.
    
    >Referencia: https://refactoring.guru/design-patterns/bridge
    
- [ ] Composite
- [ ] Decorator
- [ ] Façade
- [ ] Flyweight
- [ ] Proxy

### Behavioral Patterns ###

- [ ] Chain of Responsibility
- [ ] Command
- [ ] Interpreter
- [ ] Iterator
- [ ] Mediator
- [ ] Memento
- [ ] Observer
- [ ] State
- [ ] Strategy
- [ ] Template Method
- [ ] Visitor

### Others Design Patterns ###

- [ ] Rules Design Patterns
- [ ] Dependency Injection
- [ ] Intercepting filter
- [ ] Lazy loading
- [ ] Mock object
- [ ] Method chaining
- [ ] Inversion of control
- [ ] Unit of Work
