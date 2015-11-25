# FExtDotNet
Functional Extensions Methods for C#

## Functional Transformation Extensions
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

