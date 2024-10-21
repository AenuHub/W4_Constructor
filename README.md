## W4_Practice - Constructor

In this exercise, aiming to create a `Baby` class that utilizes two types of constructors: a default constructor and an alternative constructor. The purpose of this exercise is to demonstrate how to define and use multiple constructors within a class to handle different initialization scenarios.

### Baby Class Properties:
- **First Name**: The first name of the baby.
- **Last Name**: The last name of the baby.
- **Date of Birth**: The exact moment the baby object is created, assigned automatically.

### Constructor Details:
1. **Default Constructor**:
   - This constructor does not take any parameters.
   - When a baby object is created using this constructor, the `firstName` and `lastName` should remain unset (`None`).

2. **Alternative Constructor**:
   - This constructor accepts `firstName` and `lastName` as parameters.
   - When a baby object is created using this constructor, both the `firstName` and `lastName` will be assigned upon initialization.

### Behavior:
- In both constructors, when a baby object is created, the message `"Ingaaaa"` (a crying sound) should be displayed on the console.
- The **Date of Birth** will automatically be set to the current date and time when the object is created.
