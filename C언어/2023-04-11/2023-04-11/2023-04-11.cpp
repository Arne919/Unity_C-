#include<stdio.h>
//n1 -> num1�� �ּ�
//*n1 -> num1�� �ּ��� ��
//n2 -> num2�� �ּ�
//*n2 -> num2�� �ּ��� ��
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
	printf("%p\n", &num);//num�� �ּ�
	printf("%p\n", ptr);
	printf("%p\n", *dptr);
	printf("%p\n", **tptr);
	printf("---------------------\n");
	printf("%p\n",&ptr);//ptr�� �ּ�
	printf("%p\n",dptr);
	printf("%p\n", *tptr);
	printf("---------------------\n");
	printf("%p\n", &dptr);//dptr�� �ּ�
	printf("%p\n", tptr);
	printf("---------------------\n");
	printf("%p\n", &tptr);//tptr�� �ּ�
	*/



	/*//���� �ۼ�
	//������ ������ Ȱ���Ͽ� �� ��ȯ�� �ϱ�
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