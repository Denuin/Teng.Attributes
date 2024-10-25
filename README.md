# Teng.Attributes

## 1. [Teng.Data] 
  - **Attribute**
	 - Table
	 - PrimaryKey
	 - DbField
	 - Ignore
  - **Class**
	  - CommandParametersPair
	  - FieldValue


## 2. [Teng.Data.Interfaces] 
 - **Interface**
	- IDbHelperConfig
	- IDbHelperAdmin
	- IDbHelper


## 3. [Teng.Dependencies] 
  - **Attribute**
	 - Dependency
	 - DependencySingleInstance
	 - DependencyClass
	 - DependencyClassSingleInstance
	 - Injection
 - **Interface**
	 - InitializeApp
 - **Class**
	 - InjectionBase


## 4. [Teng.Validats] 
  - **Attribute**
	 - NumberRange
	 - StringRange
	 - Regex
	 - Required
	 - Validation
- **Extension**
	 - ValidateExtensions

---
# Change log

## 1.1.2 (2024-10-25)
- Compile with NET8.0

## 1.1.0
-   Update: namespace
-   Add: 
	-   InitializeApp
	-   InjectionBase
	-   InjectionAttribute
	-   ResolveAttribute
	-   CommandParametersPair
	-   FieldValue
	-   LoopState
	-   IDbHelper
	-   IDbHelperAdmin
	-   IDbHelperConfig

## 1.0.0
First release

> https://github.com/Denuin/Teng.Attributes
