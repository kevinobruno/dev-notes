# .NET Naming Conventions

## PascalCase

Used for:

- Class name;
- Attributes of classes;
- Methods of classes.

## camelCase

Used for:

- Method parameters;
- Local variables.

## Exceptions

1. Private attributes of classes uses `_` as prefix.

## Example

```c#
public class Customer
{
    private int _id;
    
    public string Name { get; set; }
    
    public void Charge(int amount)
    {
        var tax = 0;
    }
}
```
