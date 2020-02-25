<?
namespace demo;
use ArrayObject;

$count =0;

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
   $helloWorld =new HelloWorld();
   $helloWorld->sayHello();
}

?>