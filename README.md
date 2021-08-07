# FamilyDictionary
Collections and Linq


# The Family Dictionary

Javascript Example

```jsx
const myFamily = {
	'sister': { 
		'name': 'Krista', 
		'age': 42 
	}, 
	'mother': { 
		'name': 'Cathie', 
		'age': 70 
	}
}
```

## Instructions

1. Define a Dictionary that contains information about several members of your family. Use the following example as a template.

    ```csharp
    Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
    myFamily.Add("sister", new Dictionary<string, string>(){ {"name", "Krista"}, {"age", "42"}});
    ```

2. Next, iterate over each item in `myFamily` and produce the following output.

    ```
    Krista is my sister and is 42 years old
    ```
