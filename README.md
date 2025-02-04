# Design Patterns: Builder, Strategy, and Factory Method

## 1. Builder Pattern
### Purpose:
The **Builder Pattern** is used to construct complex objects step by step. It separates the construction logic from the representation, allowing the same construction process to create different representations.

### Usage:
- When an object requires multiple configurations.
- When an object has many optional parameters.
- When you want to create immutable objects with stepwise configuration.

### Benefits:
- Improves code readability by separating object construction.
- Provides better control over the object creation process.
- Allows reuse of the construction process for different representations.

---
## 2. Strategy Pattern
### Purpose:
The **Strategy Pattern** is used to define a family of algorithms, encapsulate each one, and make them interchangeable. This pattern allows the algorithm to be selected at runtime.

### Usage:
- When a class has multiple behaviors and you want to avoid using conditionals (if-else or switch-case statements).
- When multiple classes share the same behavior with slight variations.

### Benefits:
- Promotes the **Open-Closed Principle** (OCP) by allowing new strategies without modifying existing code.
- Enhances flexibility by dynamically selecting an algorithm at runtime.
- Improves maintainability by separating concerns and reducing code duplication.

---
## 3. Factory Method Pattern
### Purpose:
The **Factory Method Pattern** provides an interface for creating objects but allows subclasses to alter the type of objects that will be created. It delegates the responsibility of instantiating objects to subclasses.

### Usage:
- When a class does not know what specific subclass it should create.
- When the object creation process needs to be centralized and controlled.
- When you want to decouple object creation from its usage.

### Benefits:
- Enhances code reusability by abstracting object creation.
- Provides better encapsulation by hiding implementation details.
- Supports the **Single Responsibility Principle (SRP)** by separating object creation from business logic.



