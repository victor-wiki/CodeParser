# CodeParser
Parse code using antlr.

* The code of **CodeParser** library is generated using [Antlr grammar file](https://github.com/antlr/grammars-v4)(.g4), and the Antlr4.Runtime.Standard.dll
is built with its [runtime library](https://github.com/antlr/antlr4/tree/master/runtime/CSharp), which hasn't been updated to NuGet.
* The **CodeParser.Test** demonstrates how to parse source code file to extract class and interface with their properties and methods. 
By now, the Java, C#, Python, PHP, JavaScript, C++ and C language have been included.

## Example

*1. Python*
* source code
~~~
#!/usr/bin/python3
 
class HelloWorld():   
    owner = ""
    target = ""
    def sayHello(self, word):
        print(word)

x = HelloWorld() 

x.sayHello("Hello")
~~~

* parser test output
~~~
Class:HelloWorld
{
Field:owner
Field:target
Method:sayHello
}
~~~

*2. PHP*
* source code
~~~
<?
namespace demo;
use ArrayObject;

$count = 0;

class HelloWorld {
    public string $owner;
    public string $target;

	function sayHello(?string $word)
	{
		echo $word;
	}
}

function test()
{
   $helloWorld = new HelloWorld();
   $helloWorld->sayHello();
}

?>
~~~
* parser test output
~~~
Namespace:demo
Use:ArrayObject
Field:$count
Class:HelloWorld
{
Field:$owner
Field:$target
Method:sayHello
}
Function:test
~~~
