#include<stdio.h>

int main(void)
{
	int num;

	//�����Ҵ�
	int* ptr = new int;
	int* ptr2 = ptr;
	
	*ptr = 10;

	printf("%d\n", *ptr);
	printf("%p\n", ptr);
	printf("%p\n", ptr2);
	printf("--------------------\n");
	//�����Ҵ� ����
	delete(ptr);

	printf("%d\n", *ptr); //�ƹ��͵� �ȶ�
	printf("%p\n", ptr);
	printf("%p\n", ptr2);

}