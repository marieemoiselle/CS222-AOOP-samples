using System;

void Foo()
{
    int x = 10;   // Stack-allocated variable
    // ...
} // x is automatically deallocated when Foo exits.

class MyClass
{
    // Class members
}

void CreateObject()
{
    MyClass obj = new MyClass();   // Heap-allocated object
    // obj is garbage collected when no longer referenced
}

// Allocating an Object
MyClass obj = new MyClass();   // Dynamically allocate memory for MyClass

// Allocating an Array
int[] numbers = new int[5];   // Dynamically allocate memory for an integer array