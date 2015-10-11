//#include <stdio.h>


void putchar(int ch);
int getchar();
char *gets(char *str);
int puts(char *str);
void printf(char *format, int ch);


void putchar(int ch);

void f1(int a, int b, int c)
{
	putchar(b);
}

void main()
{
	f1(1, 2, 3);
}