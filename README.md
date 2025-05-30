# Half Adder ATPG Tool
**Automatic Test Pattern Generation (ATPG) for Half Adder Circuit with Stuck-at Fault Simulation**
---
Overview
This project implements a concise yet robust ATPG tool for a fundamental digital logic component - the **Half Adder**. It evaluates *stuck-at faults* on both inputs (`A`, `B`) and outputs (`SUM`, `CARRY`) by generating targeted test vectors that can detect faults efficiently. This is an essential foundational step toward scalable digital test engineering in VLSI design and verification workflows.
---
## Key Features
- **Target Fault Injection:** Select any line (`a`, `b`, `sum`, `carry`) to simulate stuck-at-0 or stuck-at-1 faults.
- **Test Vector Enumeration:** Exhaustive generation and evaluation of all possible input combinations (`A`, `B`).
- **Fault Detection Reporting:** Identifies and reports input vectors that differentiate faulty behavior from the fault-free reference.
- **Command Line Interface:** Simple argument parsing to specify fault target and stuck value.
---
## Usage
### Build
Ensure you have [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed.
```bash
mkdir HalfAdderATPG
cd HalfAdderATPG
dotnet new console
```
This directory will contain `Program.cs`.
Edit `Program.cs`
```bash
dotnet build
```
The simulation command is structured as follows:
`dotnet run -- --fault <location> --stuck <level>`
<location> is the corresponding net where the fault is present (a, b, sum, carry).
<level> is the logic where the fault is stuck (0 or 1).
```bash
dotnet run -- --fault a --stuck 0
dotnet run -- --fault a --stuck 1
dotnet run -- --fault b --stuck 0
dotnet run -- --fault b --stuck 1
dotnet run -- --fault sum --stuck 0
dotnet run -- --fault sum --stuck 1
dotnet run -- --fault carry --stuck 0
dotnet run -- --fault carry --stuck 1
```
