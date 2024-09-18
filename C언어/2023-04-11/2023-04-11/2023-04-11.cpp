#include<stdio.h>
//n1 -> num1의 주소
//*n1 -> num1의 주소의 값
//n2 -> num2의 주소
//*n2 -> num2의 주소의 값
void Change(int* n1, int* n2)
{
	int temp = *n1;
	*n1 = *n2;
	*n2 = temp;
}

int main(void)
{
	int num1 = 10;
	int num2 = 20;

	Change(&num1,&num2);

	printf("%d\n", num1);
	printf("%d\n", num2);



	/*
	int num = 10;

	int* ptr;
	int** dptr;
	int*** tptr;

	ptr = &num;
	dptr = &ptr;
	tptr = &dptr;

	printf("%d\n", num);//10
	printf("%d\n", *ptr);//10
	printf("%d\n", **dptr);//10
	printf("%d\n", ***tptr);//10
	printf("---------------------\n");
	printf("%p\n", &num);//num의 주소
	printf("%p\n", ptr);
	printf("%p\n", *dptr);
	printf("%p\n", **tptr);
	printf("---------------------\n");
	printf("%p\n",&ptr);//ptr의 주소
	printf("%p\n",dptr);
	printf("%p\n", *tptr);
	printf("---------------------\n");
	printf("%p\n", &dptr);//dptr의 주소
	printf("%p\n", tptr);
	printf("---------------------\n");
	printf("%p\n", &tptr);//tptr의 주소
	*/



	/*//내용 작성
	//포인터 변수를 활용하여 값 교환을 하기
	int num1 = 10;
	int num2 = 20;

	//int temp = num1;
	//num1 = num2;
	//num2 = temp;

	int* ptr1 = &num1;
	int* ptr2 = &num2;

	int* temp = ptr1;
	ptr1 = ptr2;
	ptr2 = temp;

	printf("%d\n", *ptr1); //20
	printf("%d\n", *ptr2); //10

	printf("%d\n", num1); //10
	printf("%d\n", num2); //20*/

}