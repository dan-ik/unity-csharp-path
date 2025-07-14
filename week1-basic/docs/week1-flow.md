```markdown
# Управление потоком

## Условные операторы
- **if / else if / else**:
  ```csharp
  if (x > 0)
  {
      Console.WriteLine("Положительное");
  }
  else if (x < 0)
  {
      Console.WriteLine("Отрицательное");
  }
  else
  {
      Console.WriteLine("Ноль");
  }
  
## switch:
```csharp
switch (choice)
{
    case 1:
        Console.WriteLine("Первый");
        break;
    case 2:
        Console.WriteLine("Второй");
        break;
    default:
        Console.WriteLine("Другой вариант");
        break;
}

Циклы
for:

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

while:
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
do…while:

int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);


foreach и коллекции
## Итерация по коллекции:
int[] numbers = {1, 2, 3, 4, 5};
foreach (var num in numbers)
{
    Console.WriteLine(num);
}