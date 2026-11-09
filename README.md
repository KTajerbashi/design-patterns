# Design Patterns in Modern C

A practical, executable reference for software design and architecture
patterns using modern C# and .NET.

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-14-239120?logo=csharp)](https://learn.microsoft.com/dotnet/csharp/)
[![License](https://img.shields.io/badge/license-see%20LICENSE-blue.svg)](LICENSE)

> **Build a practical engineering reference, not a collection of
> theoretical examples.**

This repository is intended to become a professional, practical,
educational, and production-oriented open-source reference for
intermediate and advanced software developers. It combines explanations
of design concepts with independent, executable C# implementations,
automated tests, UML diagrams, and interactive demonstrations.

> **Project status:** Active development. The catalog and architecture
> below describe the approved scope and intended organization. A pattern
> should be considered complete only when its implementation has been
> verified against the project's Definition of Done.

## Contents

-   [Project Goals](#project-goals)
-   [Technology Stack](#technology-stack)
-   [Architecture](#architecture)
-   [Pattern Catalog](#pattern-catalog)
-   [Anti-pattern Catalog](#anti-pattern-catalog)
-   [Standard Pattern Structure](#standard-pattern-structure)
-   [Shared UI Design System](#shared-ui-design-system)
-   [Getting Started](#getting-started)
-   [Quality and Testing](#quality-and-testing)
-   [Roadmap](#roadmap)
-   [Project Status](#project-status)
-   [Contributing](#contributing)
-   [Governance and Security](#governance-and-security)
-   [License](#license)

## Project Goals

The project aims to provide a practical reference for:

-   Object-Oriented Design and Design Patterns
-   Software Design Principles
-   Architectural and Enterprise Application Patterns
-   Domain-Driven Design (DDD)
-   Distributed Systems and Integration Patterns
-   Concurrency and Parallel Programming
-   Reliability, Performance, and Data Patterns
-   Security and Testing Patterns
-   Software Anti-patterns and Refactoring Techniques
-   Modern C# and .NET Engineering

The repository is designed to support:

-   Professional software engineering portfolios
-   Software engineering interviews
-   Intermediate and senior developers
-   Architecture and design education
-   Real-world software development
-   Open-source learning and contributions

The examples should demonstrate why a pattern is useful in a realistic
scenario---not merely reproduce its UML structure. Implementations are
expected to be technically correct, executable, testable, and
appropriately scoped.

## Technology Stack

The approved baseline is:

  Area                       Technology / Decision
  -------------------------- ---------------------------------
  Primary language           C# 14
  Platform                   .NET 10 LTS
  Web UI                     Blazor Web App
  Blazor render mode         Interactive Server by default
  Core architecture          Independent Core + Blazor App
  Unit testing               xUnit
  Blazor component testing   bUnit
  Diagrams                   Mermaid
  CI/CD                      GitHub Actions
  Package management         Central Package Management
  Code quality               .NET analyzers and EditorConfig

Additional tools are introduced only when a concrete implementation
requires them:

-   `Microsoft.AspNetCore.Mvc.Testing`
-   `Microsoft.Playwright`
-   `BenchmarkDotNet`
-   `Testcontainers`

The project avoids unnecessary dependencies, duplicated business logic,
artificial abstractions, and hidden dependencies between independent
pattern applications.

## Architecture

The repository follows a modular structure. Each pattern has its own
independent Blazor application, while its domain and business logic
remain independent of Blazor.

### Repository layout

The following is the approved target organization. The actual repository
may be populated incrementally as development proceeds.

``` text
design-patterns/
├── docs/
│   ├── getting-started.md
│   ├── design-principles.md
│   ├── solid-principles.md
│   ├── grasp-principles.md
│   ├── pattern-selection-guide.md
│   ├── architecture-principles.md
│   ├── coding-standards.md
│   ├── testing-strategy.md
│   ├── glossary.md
│   ├── catalog/
│   └── architecture/
│       └── adr/
│
├── src/
│   ├── Creational/
│   ├── Structural/
│   ├── Behavioral/
│   ├── Enterprise/
│   ├── DomainDrivenDesign/
│   ├── Architectural/
│   ├── DistributedSystems/
│   ├── Integration/
│   ├── Concurrency/
│   ├── Security/
│   ├── Testing/
│   └── Shared/
│
├── tests/
│   ├── Creational.Tests/
│   ├── Structural.Tests/
│   ├── Behavioral.Tests/
│   ├── Enterprise.Tests/
│   ├── DomainDrivenDesign.Tests/
│   ├── Architectural.Tests/
│   ├── DistributedSystems.Tests/
│   ├── Integration.Tests/
│   ├── Concurrency.Tests/
│   ├── Security.Tests/
│   └── Testing.Tests/
│
├── .github/
│   ├── workflows/
│   ├── ISSUE_TEMPLATE/
│   ├── PULL_REQUEST_TEMPLATE.md
│   ├── CODEOWNERS
│   └── dependabot.yml
│
├── .editorconfig
├── .gitattributes
├── .gitignore
├── global.json
├── Directory.Build.props
├── Directory.Packages.props
├── DesignPatterns.sln
├── README.md
├── LICENSE
├── CONTRIBUTING.md
├── CODE_OF_CONDUCT.md
├── SECURITY.md
├── SUPPORT.md
└── CHANGELOG.md
```

### Individual pattern structure

Each pattern is organized into two independently maintained projects:

``` text
PatternName/
├── PatternName.Core/
│   ├── Abstractions/
│   ├── Models/
│   ├── Services/
│   └── PatternName.Core.csproj
│
└── PatternName.BlazorApp/
    ├── Components/
    ├── Pages/
    ├── Layout/
    ├── wwwroot/
    ├── Program.cs
    └── PatternName.BlazorApp.csproj
```

**Core responsibilities**

-   Contains the pattern's domain and business logic.
-   Does not depend on Blazor.
-   Can be tested independently.
-   Uses abstractions only where they provide meaningful value.

**Blazor application responsibilities**

-   Presents the pattern's explanation and interactive demonstration.
-   References the corresponding Core project.
-   Uses the shared UI design system for consistent presentation.

### Namespace convention

``` csharp
DesignPatterns.[Category].[PatternName].Core
DesignPatterns.[Category].[PatternName].BlazorApp
```

Test projects are organized by category. Shared projects contain
reusable infrastructure and presentation components; they must not
become a place for unrelated pattern implementations.

Patterns that appear in more than one domain should have one canonical
implementation with cross-references rather than duplicated
implementations.

## Pattern Catalog

The approved version 1.0 scope contains **122 Design and Architecture
Pattern entries** across nine catalog groups. This is the project's
defined implementation scope, not a claim to include every known
software pattern.

### 1. GoF Design Patterns --- 23

```{=html}
<details>
```
```{=html}
<summary>
```
`<strong>`{=html}Creational --- 5`</strong>`{=html}
```{=html}
</summary>
```
1.  Singleton
2.  Factory Method
3.  Abstract Factory
4.  Builder
5.  Prototype

```{=html}
</details>
```
```{=html}
<details>
```
```{=html}
<summary>
```
`<strong>`{=html}Structural --- 7`</strong>`{=html}
```{=html}
</summary>
```
6.  Adapter
7.  Bridge
8.  Composite
9.  Decorator
10. Facade
11. Flyweight
12. Proxy

```{=html}
</details>
```
```{=html}
<details>
```
```{=html}
<summary>
```
`<strong>`{=html}Behavioral --- 11`</strong>`{=html}
```{=html}
</summary>
```
13. Chain of Responsibility
14. Command
15. Interpreter
16. Iterator
17. Mediator
18. Memento
19. Observer
20. State
21. Strategy
22. Template Method
23. Visitor

```{=html}
</details>
```
### 2. Enterprise Application Patterns --- 15

24. Repository\
25. Unit of Work\
26. Specification\
27. Data Mapper\
28. Active Record\
29. Identity Map\
30. Lazy Load\
31. Query Object\
32. Data Transfer Object\
33. Service Layer\
34. Transaction Script\
35. Domain Model\
36. Table Module\
37. Gateway\
38. Remote Facade

### 3. Domain-Driven Design --- 12

**Strategic DDD**

39. Bounded Context\
40. Context Map\
41. Shared Kernel\
42. Customer-Supplier\
43. Anti-Corruption Layer\
44. Open Host Service\
45. Published Language

**Tactical DDD**

46. Entity\
47. Value Object\
48. Aggregate\
49. Domain Service\
50. Domain Event

### 4. Architectural Patterns --- 16

51. Layered Architecture\
52. N-Tier Architecture\
53. Clean Architecture\
54. Hexagonal Architecture\
55. Onion Architecture\
56. Modular Monolith\
57. Microservices Architecture\
58. Service-Oriented Architecture\
59. Event-Driven Architecture\
60. Pipe and Filter\
61. Broker Architecture\
62. Microkernel Architecture\
63. Space-Based Architecture\
64. Client-Server Architecture\
65. Model-View-Controller\
66. Model-View-ViewModel

Additional concepts---including MVP, BFF, Serverless, Reactive
Architecture, Peer-to-Peer, and Strangler Fig---are supplementary
documentation topics. They do not increase the fixed 122-entry
implementation count.

### 5. Distributed Systems and Integration --- 20

67. Point-to-Point Messaging\
68. Publish-Subscribe\
69. Request-Reply\
70. Message Router\
71. Content-Based Router\
72. Message Filter\
73. Message Translator\
74. Splitter\
75. Aggregator\
76. Scatter-Gather\
77. Competing Consumers\
78. Dead Letter Channel\
79. Saga\
80. Transactional Outbox\
81. Inbox / Idempotent Consumer\
82. Event Sourcing\
83. CQRS\
84. Change Data Capture\
85. API Gateway\
86. Sidecar

### 6. Concurrency and Parallel Programming --- 10

87. Active Object\
88. Producer-Consumer\
89. Thread Pool\
90. Future / Promise\
91. Guarded Suspension\
92. Balking\
93. Reactor\
94. Proactor\
95. Half-Sync / Half-Async\
96. Leader-Followers

Synchronization primitives---including Mutex, Semaphore, Monitor, and
Reader-Writer Lock---are also documented.

### 7. Reliability, Performance and Data --- 10

97. Circuit Breaker\
98. Retry\
99. Bulkhead\
100. Timeout\
101. Rate Limiting\
102. Cache-Aside\
103. Read-Through Cache\
104. Write-Through Cache\
105. Write-Behind Cache\
106. Consistent Hashing

Replication, Sharding, Partitioning, Quorum, Backpressure, and Cache
Stampede are additional topics.

### 8. Security Patterns --- 8

107. Role-Based Access Control (RBAC)\
108. Attribute-Based Access Control (ABAC)\
109. Zero Trust Architecture\
110. Defense in Depth\
111. Least Privilege\
112. Secure Gateway\
113. Secure Session Management\
114. Audit Logging

### 9. Testing Patterns --- 8

115. Test Double\
116. Mock Object\
117. Test Data Builder\
118. Object Mother\
119. Contract Testing\
120. Consumer-Driven Contract\
121. Test Fixture\
122. Page Object

## Anti-pattern Catalog

The approved version 1.0 scope includes **30 mandatory Anti-patterns**.
Each is studied through its symptoms, causes, consequences, and a
practical refactoring strategy.

### Code and Object-Oriented Anti-patterns --- 10

1.  God Object
2.  Spaghetti Code
3.  Golden Hammer
4.  Lava Flow
5.  Copy-Paste Programming
6.  Primitive Obsession
7.  Anemic Domain Model
8.  Shotgun Surgery
9.  Feature Envy
10. Circular Dependency

### Architecture Anti-patterns --- 10

11. Big Ball of Mud
12. Distributed Monolith
13. Premature Microservices
14. Shared Database Anti-pattern
15. Tight Coupling
16. Layer Leakage
17. Overengineering
18. Vendor Lock-in
19. Architecture Astronaut
20. Accidental Complexity

### Distributed Systems Anti-patterns --- 5

21. Chatty Services
22. Dual Writes
23. Retry Storm
24. Cache Stampede
25. N+1 Query Problem

### Async and Concurrency Anti-patterns --- 5

26. Sync-over-Async
27. Async Void
28. Fire-and-Forget
29. Unbounded Concurrency
30. Shared Mutable State

Additional testing and security anti-patterns are documented in their
relevant categories and linked to related examples. They are
supplementary topics, not additions to the fixed 30-item catalog.

## Standard Pattern Structure

Every pattern follows a consistent educational and engineering template:

1.  Intent
2.  Problem
3.  Bad or Naive Implementation
4.  Solution
5.  UML Diagram
6.  Participants and Responsibilities
7.  Core Implementation
8.  Blazor Interactive Demo
9.  Real-world Scenario
10. Advantages
11. Disadvantages
12. When to Use
13. When NOT to Use
14. Trade-offs
15. Alternatives
16. Related Patterns
17. Unit Tests
18. Edge Cases
19. References

Anti-patterns use a dedicated template:

1.  Definition
2.  Symptoms
3.  Root Causes
4.  Bad Implementation
5.  Why It Is Harmful
6.  Consequences
7.  Refactoring Strategy
8.  Improved Implementation
9.  Before/After Comparison
10. Tests
11. Real-world Scenario
12. Related Patterns
13. References

Every example must be executable and technically correct. Public APIs
should be documented where useful, and important edge cases must be
tested.

## Shared UI Design System

All pattern applications follow consistent visual and interaction
standards. The shared UI project is responsible for reusable
presentation components.

Required shared components:

-   `PatternHeader`
-   `PatternNavigation`
-   `PatternOverview`
-   `ProblemSolutionPanel`
-   `CodeViewer`
-   `UmlDiagram`
-   `LiveDemo`
-   `AdvantagesDisadvantages`
-   `UseCasePanel`
-   `PatternComparison`
-   `RelatedPatterns`
-   `ReferencesPanel`

Required UI capabilities:

-   Responsive layout
-   Light and dark themes
-   Sidebar navigation and breadcrumbs
-   Code syntax highlighting and copy support
-   UML diagram display
-   Pattern category badges
-   Search and filtering
-   Related pattern navigation
-   Consistent typography
-   Accessible UI components

## Getting Started

### Prerequisites

Install the .NET 10 SDK. A compatible development environment for C# and
ASP.NET Core is also recommended.

Verify the installed SDK:

``` bash
dotnet --list-sdks
dotnet --version
```

### Clone the repository

``` bash
git clone https://github.com/KTajerbashi/design-patterns.git
cd design-patterns
```

### Restore, build, and test

The repository's approved solution filename is `DesignPatterns.sln`.
From the repository root, the standard solution-level commands are:

``` bash
dotnet restore DesignPatterns.sln
dotnet build DesignPatterns.sln --no-restore
dotnet test DesignPatterns.sln --no-build
```

These commands assume the solution and corresponding projects are
present and configured. During active development, a particular project
may be built or tested independently.

### Run a pattern application

Each pattern has its own Blazor application. Run the relevant
application project directly:

``` bash
dotnet run --project path/to/PatternName.BlazorApp/PatternName.BlazorApp.csproj
```

Replace the example path with the actual project path. Consult the
pattern's README or documentation for its specific demonstration
instructions.

## Quality and Testing

The project adopts the following engineering standards:

-   Nullable Reference Types enabled.
-   Implicit Usings enabled where appropriate.
-   Central Package Management.
-   Consistent namespaces and formatting.
-   .NET analyzers and static analysis.
-   XML documentation for public APIs where useful.
-   Dependency auditing and no unnecessary packages.
-   No duplicated business logic.
-   No hidden dependencies between independent pattern applications.
-   Appropriate exception handling and async/await practices.
-   Dependency Injection where appropriate.
-   SOLID and Clean Code principles.

### Testing strategy

-   **xUnit** for unit tests.
-   **bUnit** for Blazor component tests.
-   Integration and end-to-end testing tools when justified by the
    implementation.
-   Code coverage as part of quality validation.

### Definition of Done

A pattern is not complete merely because code has been written.
Completion requires verification that:

-   [ ] Core implementation is independent of Blazor.
-   [ ] The Blazor application builds and runs.
-   [ ] A meaningful real-world scenario is provided.
-   [ ] The UML diagram matches the implementation.
-   [ ] The problem and solution are explained.
-   [ ] Unit tests pass.
-   [ ] Important edge cases are tested.
-   [ ] The English README is complete.
-   [ ] Advantages, disadvantages, and alternatives are discussed.
-   [ ] Related patterns are linked.
-   [ ] The project is included in the main solution.
-   [ ] CI succeeds.

Anti-patterns apply equivalent criteria to both the problematic and
refactored implementations. A checklist tracks completion.

## Roadmap

The approved execution order for version 1.0 is:

  Phase     Scope
  --------- -------------------------------------
  Phase 0   Infrastructure
  Phase 1   Design Principles and Foundations
  Phase 2   GoF Design Patterns
  Phase 3   Enterprise and DDD
  Phase 4   Software Architecture
  Phase 5   Distributed Systems and Integration
  Phase 6   Concurrency and Reliability
  Phase 7   Security and Testing
  Phase 8   Anti-patterns
  Phase 9   Finalization and Release

The 152 catalog implementation days are a planning target, not a
guarantee. Phase 0 and Phase 1 are preparation and foundation work and
are not included in that count.

The catalog execution order is maintained as follows:

  Target days   Catalog scope
  ------------- -----------------------------
  1--5          Creational
  6--12         Structural
  13--23        Behavioral
  24--38        Enterprise
  39--50        DDD
  51--66        Architectural
  67--86        Distributed and Integration
  87--96        Concurrency
  97--106       Reliability and Data
  107--114      Security
  115--122      Testing
  123--152      Anti-patterns

The numbered catalog order is the default implementation order. Changes
to established scope or architecture require a documented technical
reason, consideration of alternatives, an Architecture Decision Record
(ADR), and the repository owner's approval.

## Project Status

The repository is the source of truth for implementation progress. The
project progress record is maintained in:

``` text
docs/PROJECT-STATUS.md
```

It tracks:

-   Current phase and day
-   Current category and pattern
-   Last completed pattern
-   Completed, in-progress, and pending patterns
-   Completed anti-patterns
-   Infrastructure, Shared UI, testing, and CI/CD status
-   Outstanding technical decisions and open issues
-   Next action

A pattern must not be marked complete based only on discussion or
generated code; its acceptance criteria and implementation must be
verified.

## Contributing

Contributions are welcome when they preserve the project's architecture,
scope, quality standards, and educational goals.

Before contributing:

1.  Review the project documentation and coding standards.
2.  Check the existing implementation before creating a new pattern or
    abstraction.
3.  Avoid duplicate implementations; use canonical implementations and
    cross-references.
4.  Keep pattern Core logic independent of Blazor.
5.  Include meaningful tests, edge cases, and documentation.
6.  Keep code, comments, class names, and UI text in English.
7.  Run the relevant build, test, and formatting checks.
8.  Explain architectural changes and propose an ADR when needed.

See [CONTRIBUTING.md](CONTRIBUTING.md) for contribution instructions
when available.

## Governance and Security

Architecture decisions are documented as ADRs. Each ADR should include:

-   Title
-   Status
-   Context
-   Problem
-   Considered Options
-   Decision
-   Consequences
-   Date

The repository is intended to include GitHub Actions CI, build and test
validation, formatting checks, static analysis, code coverage, CodeQL,
Dependabot, issue templates, pull request templates, and a security
policy.

For security concerns, follow [SECURITY.md](SECURITY.md) when available.
Do not include credentials, tokens, connection strings, or other secrets
in source code or issues.

## License

See the [LICENSE](LICENSE) file for the terms under which this project
is distributed.
