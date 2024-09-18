#include<stdio.h>

int main(void)
{
	int num;

	//동적할당
	int* ptr = new int;
	int* ptr2 = ptr;
	
	*ptr = 10;

	printf("%d\n", *ptr);
	printf("%p\n", ptr);
	printf("%p\n", ptr2);
	printf("--------------------\n");
	//동적할당 해제
	delete(ptr);

	printf("%d\n", *ptr); //아무것도 안뜸
	printf("%p\n", ptr);
	printf("%p\n", ptr2);

}