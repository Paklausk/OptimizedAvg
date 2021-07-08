# OptimizedAvg
[![GitHub](https://img.shields.io/github/license/Paklausk/OptimizedAvg?style=for-the-badge)](https://github.com/Paklausk/OptimizedAvg/blob/master/LICENSE)
[![GitHub last commit](https://img.shields.io/github/last-commit/Paklausk/OptimizedAvg.svg?style=for-the-badge)]()
 
 Alternative average number calculation algorithm where one doesn't need to have all numbers or a sum of all numbers.

Basically algorithm is:
```csharp
avg = avg - (avg / allNumbersCount) + (newValue / allNumbersCount);
```

### Why it was needed?
Just for fun.
