#include <iostream.h>
#include <string>

using namespace std;

main()
{
    cout << "Hello World!";
    return 0;
}

class HelloWorld
{
public:
	string owner, target;
	int age;
	

public:
	void sayHello(string word)
	{
		cout << word;
	}

	void test()
	{
		cout << "Test";
	}
};

