using System;

for (int i = 1; i <= 10; i++) {
    if (i % 2 == 1) {
        continue;
    }
    Console.Write($"{i} ");
}