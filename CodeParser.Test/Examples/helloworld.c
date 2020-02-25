#include <stdio.h>

char *owner;
char *target;

sayHello(char word[])
{
	int i = 0;
	while (word[i] != '\0')
	{
		printf("%c", word[i]);
		i++;
	}	
}

main()
{
	sayHello("Hello");
}

