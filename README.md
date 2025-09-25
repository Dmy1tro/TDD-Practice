# String Calculator – TDD Practice in C#

This repository demonstrates the **Test-Driven Development (TDD)** workflow.  
It is intended as a **reference for unit testing and TDD skills** (e.g., for PPR / performance review).

---

## 🎯 Purpose

- Showcase the ability to write **clean, effective unit tests**.  
- Demonstrate strict adherence to the **TDD cycle**:
  - Write a failing test (**Red**)  
  - Implement the minimal code to pass (**Green**)  
  - Improve code design with confidence (**Refactor**)  
- Illustrate incremental feature development **driven entirely by tests**.  

---

## 🛠️ TDD Workflow Example

This project followed the **Red–Green–Refactor** loop.  

Example progression:

1. **Red** - Write a failing test:  
   ```csharp
   [Test]
   public void Add_EmptyString_ReturnsZero()
   {
       var result = _calculator.Add("");
       Assert.That(result, Is.EqualTo(0));
   }
2. **Green** – Implement minimal production code:
   ```csharp
   public int Add(string numbers)
   {
      if (string.IsNullOrEmpty(numbers))
          return 0;
      return int.Parse(numbers);
   }
3. **Refactor** – Improve design as new cases arrive.
   Each new rule was introduced only after writing a failing test
