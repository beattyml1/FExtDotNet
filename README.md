# FExtDotNet
Functional Extensions Methods for C#

## Functional Transformation/Composition Extensions
### Transform
Forward pipe, like F# and Elixir's |> operator. 
Usage:
```
var x = value.Transform(function1);
var x = value.Transform(function1, function2);
var x = value
  .Transform(function1)
  .Transform(function2)
```

### Parameterize
Pass additional parameters to a function in addition to this
```
var x = value.Transform(function1.Parameterize(1, "Testing"));
var x = value.Transform(function1.Parameterize(1, "Testing"), function2);
var x = value
  .Transform(function11.Parameterize(1, "Testing"))
  .Transform(function2)
```

### Compose
Compose/chain multiple functions together into a single function
```
var func = function1.Compose(function2.Parameterize(1, "Testing"));
var func = function1.Compose(function2, function3);
var func = function1
  .Compose(function2.Parameterize(1, "Testing"))
  .Compose(function3)

var func = Composition.Compose(function1.Parameterize(1, "Testing"));
var func = Composition.Compose(function1, function2, function3);
var func = Composition
  .Compose(function2.Parameterize(1, "Testing"))
  .Compose(function3)
```

### Into
Store a value into a variable, useful for commands that returns something like a status that is not super useful but still must be stored.
Usage:
```
int x;
value.Transform(function1, function2).Into(out x);
```

## Enumerable Extensions

### ForEach
A basic functional foreach. If we have architected the application properly commands in loops should already be a single named function and should thus be much more readable this way than a traditional for loop.
```
posts.ForEach(DataAccess.Save);
posts.ForEach(DataAccess.Save.Parameterize(true));
posts.ForEach(post => post.Save());
```

### ForEachAndSelect
A basic functional foreach that returns results. Use for commands that must execute and return a value that may or may not be used. Different than LINQ select because it is guaranteed to execute the function even if the return collection is never enumerated.
```
posts.ForEachAndSelect(x => DataAccess.Save(x).Id);
```

### ToDictionary
Convert IEnumerable of KeyValuePair to dictionary without having to remap key and value. Useful when doing operations on an existing dictionary where we want to return a dictionary back at the end.
```
dictionary.Where(x => x.SomeCondition).ToDictionary();
```

### Group and Sum
Group by a key and sum a value
```
var pricePerOrder = itemsPurchaseByUser.GroupAndSum(x => x.OrderId, x => x.PurchasePrice);
```


