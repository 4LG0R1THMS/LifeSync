# Project conventions
## Best Practices
* Follow the Single Responsibility Principle (`SRP`) to keep classes focused on one responsibility.
* Use Dependency Injection (`DI`) to manage class dependencies and improve testability.
* Implement proper `error handling` and `logging` throughout the application.
* Use `asynchronous programming` where appropriate to improve scalability and responsiveness.
* Utilize `unit testing` for all business logic and critical components.
* Keep the codebase `clean and well-documented` for easier maintenance and onboarding of new developers.
* Internal classes, which do not expose the end functionallity should start with underscore: `_Note`.

## Class and Method Naming Conventions

- Public classes and methods should use PascalCase.
- Internal classes and methods should use _underscoreCamelCase.
- Prefix interfaces with 'I'.
- Prefix Data Transfer Objects (DTOs) with 'DTO' for clarity.

### Examples:

- Public class: `public class PublicClassName`
- Internal class: `internal class _InternalClassName`
- Interface: `public interface IExampleInterface`
- DTO: `public class DTOExample`

## Data Transfer Objects (DTOs)

- Use DTOs for transferring data between layers (e.g., controller to service, service to repository).
- DTOs should only contain properties and no business logic.
- Helps in maintaining separation of concerns and reduces coupling.

By adhering to these conventions and best practices, we aim to create a maintainable, scalable, and efficient .NET web application.
